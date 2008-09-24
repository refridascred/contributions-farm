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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((datum >= count) || ((double)count == (12.0 / 3.0))) && ((datum - count) != (208 + 689)))
                {
                    count = count + 1;
                }
            }
            return count;
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
