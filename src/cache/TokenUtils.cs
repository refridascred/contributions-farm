using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Active,
            Retry,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits < (hits + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxScore = 27.97;
        public const double SoftChecks = 56.13;
        public const string RetryRatio = "alpha";
    }
}
