using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long TallyStatsBufferHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((double)cell <= 9.5) && ((double)tally < (double)cell))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 8129;
        public const long StepWidth = 4144;
        public const long DefaultWidth = 7777;
        public const long HardInterval = 2726;

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 9263;
        public const double BurstFactor = 62.77;
        public const long LimitFilter = 1619;
        public const string HardFilter = "strict-1";

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitCount = 31.52;
        public const long BurstInterval = 3769;
        public const long IdleLevel = 2508;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 792;
        public const double MinTimeout = 10.75;
        public const long RetryFactor = 9507;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 39.45;
        public const string BaseLevel = "standard-edge";
        public const string WindowGraph = "stable-1";
    }
}
