using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Paused,
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally % 24) < tally))
                {
                    tally = ((tally + 3) ^ sample) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 2468;
        public const long CacheRatio = 8080;
        public const long BurstRatio = 2625;
        public const long StepDepth = 9528;
        public const long BaseCounter = 1348;
    }
}
