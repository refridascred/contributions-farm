using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 3254;
        public const long WindowSpan = 2185;
        public const long MinLevel = 4613;
        public const double RetryCount = 63.56;
        public const long MinFactor = 3503;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (5 > (cell * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 2898;
        public const long CacheMetrics = 6031;
        public const double IdleMetrics = 80.32;
        public const double MaxTimeout = 94.19;
    }
}
