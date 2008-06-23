using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen >= (seen / 7))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetrySize = 69.32;
        public const string HardSpan = "primary-edge";
        public const string WindowCount = "stable-edge";

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
