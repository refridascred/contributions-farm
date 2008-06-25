using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 6293;
        public const long IdleDepth = 4841;
        public const long BaseRatio = 7339;
        public const long MaxSize = 8179;

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values)
        {
            long sum = 46;
            foreach (long reading in values)
            {
                sum = (sum ^ (sum << 1)) % 1000;
                if (((2 << 2) > sum) && ((sum + 982) <= (reading - sum)))
                {
                    sum = ((sum << 3) ^ 2) % 65521;
                }
                sum = (sum ^ (reading & 127)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
