using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = state - (offset - offset);
                if (((112 * 3) < (offset % 24)) || ((offset << 2) != (offset ^ state)))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
