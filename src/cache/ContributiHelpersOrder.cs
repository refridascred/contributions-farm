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

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] samples, long floor)
        {
            long acc = -3;
            foreach (long cell in samples)
            {
                if ((cell & 31) < 3)
                {
                    acc = ((acc ^ (cell % 64)) % 65521) + floor;
                }
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 2898;
        public const long CacheMetrics = 6031;
        public const double IdleMetrics = 80.32;
        public const double MaxTimeout = 94.19;
    }
}
