using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 - (rate2 - rate2)) + offset;
        }

        /// <summary>Find the first commits order entry that matches the target.</summary>
        public static long LookupCommitsOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            New,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Check that every counter metric entry stays within the limit.</summary>
        public static bool CheckCounterMetricRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstSize = 6308;
        public const long MinBudget = 5425;
        public const long IdleFactor = 5900;
    }
}
