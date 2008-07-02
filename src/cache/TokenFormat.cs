using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Stale,
            Queued,
            Done,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell ^ cell) >= (tally + 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((37 << 2) >= (seed >> 3))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }
    }
}
