using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "staging-edge";
        public const string CacheMetric = "primary-1";
        public const long RetryTimeout = 8901;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 11.51;
        public const long MinSession = 4069;
        public const double MaxSession = 54.63;
        public const long MaxInterval = 9251;
        public const long BatchTimeout = 1235;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout metrics values into a single score.</summary>
        public static long CombineLayoutMetrics(long[] readings)
        {
            long result = 73;
            foreach (long entry in readings)
            {
                result = ((result << 2) ^ (entry % 16)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample >= (sample >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
