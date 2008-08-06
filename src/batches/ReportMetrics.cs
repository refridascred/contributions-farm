using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((4.11 * 19.0) > (double)hits)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryInterval = 82.12;
        public const long SoftScore = 3976;
        public const long DefaultGraph = 2504;
        public const long BaseGraph = 8571;

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 7036;
        public const long HardRatio = 9497;
        public const long BatchSize = 1880;
    }
}
