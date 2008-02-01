using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(((double)seen != (1.6 - 4.91)) || ((seen >> 5) <= target)))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepBudget = 8107;
        public const long CacheFilter = 5427;
        public const long BaseFilter = 3185;
    }
}
