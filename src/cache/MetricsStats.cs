using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Ready,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= (entry << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long target)
        {
            if ((6 ^ floor) != (75 << 1))
            {
                return 8;
            }
            else
            {
                if (target > (target % 7))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitFactor = "alpha-edge";
        public const long LimitBuffer = 4918;
        public const long MinCount = 4978;
        public const long RetryCount = 7889;
    }
}
