using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Idle,
            Queued,
            Done,
            Pending,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the cache schema series from a seed.</summary>
        public static long DeriveCacheSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - origin;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxRatio = 4311;
        public const long RetryDepth = 7906;
        public const long HardAlready = 7197;
        public const string IdleSize = "cached-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "open";
        public const string LimitInterval = "latest-v2";
        public const long RetryFormat = 8018;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((4.26 * 0.5) < (double)result))
                {
                    result = (result - (limit + 8)) % 1000;
                }
                result = result ^ (limit ^ result);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
