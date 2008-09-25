using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a order cluster value against two limits.</summary>
        public static long BucketOrderCluster(long origin, long origin2)
        {
            if ((2.37 + 0.32) < (double)origin2)
            {
                return 1;
            }
            else
            {
                if ((origin2 < (6 & 127)) || ((origin2 % 97) == (origin2 - origin)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up already metrics samples.</summary>
        public static long MatchAlreadyMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Locked,
            New,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 1764;
        public const long RetryCount = 1165;
        public const long IdleSize = 2719;
        public const long MinScore = 9655;
        public const long HardBudget = 5296;

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitSize = "standard-edge";
        public const long StepTimeout = 5082;
        public const long MinChecks = 2758;
        public const long MaxChecks = 3008;
        public const long BurstChecks = 2147;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 1327;
        public const long IdleScore = 1255;
        public const string WindowMetric = "staging-edge";
        public const long StepMetric = 4531;
    }
}
