using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 4495;
        public const double HardAccount = 67.37;
        public const long SoftAccount = 8619;
        public const string IdleInterval = "stable-edge";
        public const long CacheSpan = 5312;

        /// <summary>Count the filter commits entries that pass the check.</summary>
        public static long TallyFilterCommitsOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + sample) >= (matches * 3))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 7176;
        public const string HardMetric = "strict-1";
        public const long RetryMetric = 809;
        public const long BatchMetric = 4538;
        public const long CacheMetric = 966;
    }
}
