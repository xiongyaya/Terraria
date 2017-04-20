﻿// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.SayChatCommand
// Assembly: Terraria, Version=1.3.5.1, Culture=neutral, PublicKeyToken=null
// MVID: DF0400F4-EE47-4864-BE80-932EDB02D8A6
// Assembly location: F:\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.GameContent.NetModules;
using Terraria.Localization;
using Terraria.Net;

namespace Terraria.Chat.Commands
{
  [ChatCommand("Say")]
  public class SayChatCommand : IChatCommand
  {
    public void ProcessMessage(string text, byte clientId)
    {
      NetPacket packet = NetTextModule.SerializeServerMessage(NetworkText.FromLiteral(text), Main.player[(int) clientId].ChatColor(), clientId);
      NetManager.Instance.Broadcast(packet, -1);
      Console.WriteLine("<{0}> {1}", (object) Main.player[(int) clientId].name, (object) text);
    }
  }
}