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

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Done,
            Retry,
            Paused,
            Closed,
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
