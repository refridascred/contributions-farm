using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long target, long floor)
        {
            if (9.68 < (double)target)
            {
                return 0;
            }
            else
            {
                if ((double)target <= (double)472)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Retry,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 32.25;
        public const long CacheRecord = 1733;
        public const double LimitRecord = 41.89;
    }
}
