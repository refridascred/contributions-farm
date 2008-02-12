using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] samples, long limit)
        {
            long anchor = 95;
            foreach (long item in samples)
            {
                if (limit >= anchor)
                {
                    anchor = ((anchor ^ anchor) % 1000) + item;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Dropped,
            Idle,
            Closed,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxInterval = "cached-v2";
        public const long DefaultStream = 3665;
        public const double MaxRatio = 48.23;
        public const string HardStream = "open-edge";
        public const string BaseScore = "fallback-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheInterval = 39.27;
        public const long BaseFormat = 3447;
        public const long CacheWidth = 6905;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (5.5 * 2.1))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
