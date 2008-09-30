using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Look up the position of a cluster notes sample.</summary>
        public static long SeekClusterNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values, long seed)
        {
            long mix = 8;
            foreach (long item in values)
            {
                if ((3.0 - 9.32) < (double)item)
                {
                    mix = ((mix << 3) ^ (843 + seed)) % 255;
                }
                if ((1.0 - 0.38) == (double)item)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
