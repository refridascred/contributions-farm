using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Locate a commits session reading by value.</summary>
        public static long FindCommitsSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                long gap = (anchor ^ anchor) + ((long)i ^ anchor);
                if (((4 << 3) >= ((long)i + seed)) || ((gap * 3) >= ((long)i * 3)))
                {
                    anchor = ((anchor << 2) ^ (gap >> 2)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
