using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryTimeout = 7461;
        public const long SoftRatio = 2875;
        public const long BurstStats = 2252;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Dropped,
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((14.0 + 16.0) >= (15.0 * 6.38)) || ((hits & 7) >= (sample >> 4)))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }
    }
}
