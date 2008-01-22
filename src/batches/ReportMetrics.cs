using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryInterval = "legacy-v2";
        public const double LimitStream = 28.82;
        public const long CacheScore = 2268;
        public const long SoftDepth = 2959;

        /// <summary>Validate farm commits readings against a bound.</summary>
        public static bool ValidateFarmCommitsLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits & 255) <= hits)
                {
                    hits = ((hits + 2) + entry) + offset;
                }
            }
            return hits;
        }
    }
}
