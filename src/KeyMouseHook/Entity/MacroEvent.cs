﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loamen.KeyMouseHook
{
    /// <summary>
    /// Series of events that can be recorded any played back
    /// </summary>
    [Serializable]
    public class MacroEvent : EventArgs
    {
        public MacroEventType KeyMouseEventType;
        public EventArgs EventArgs;
        public int TimeSinceLastEvent;

        public MacroEvent(MacroEventType eventType, EventArgs eventArgs, int timeSinceLastEvent)
        {
            KeyMouseEventType = eventType;
            EventArgs = eventArgs;
            TimeSinceLastEvent = timeSinceLastEvent;
        }
    }

    /// <summary>
    /// Event type
    /// </summary>
    [Serializable]
    [FlagsAttribute]
    public enum MacroEventType
    {
        MouseMove = 1,
        MouseMoveExt = 2,
        MouseDown = 4,
        MouseDownExt = 8,
        MouseUp = 16,
        MouseUpExt = 32,
        MouseWheel = 64,
        MouseWheelExt = 128,
        MouseDragStarted = 256,
        MouseDragFinished = 512,
        MouseDoubleClick = 1024,
        KeyDown = 2048,
        KeyUp = 4096,
        KeyPress = 8192
    }
}
