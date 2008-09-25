using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of stream editor readings.</summary>
        public static long OverlapStreamEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
