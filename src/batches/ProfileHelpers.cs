using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double weight, double bias)
        {
            double load = 0.1;
            if (load > (load * 5.92))
            {
                load = (load + (double)(-47)) + bias;
            }
            else
            {
                load = load + weight;
            }
            return load - weight;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a stats counter reading.</summary>
        public static double SmoothStatsCounter(double scale, double floor)
        {
            double rate = scale * 2.53;
            if (rate > (13.0 + rate))
            {
                rate = rate + (floor / 5.0);
            }
            else
            {
                rate = rate - 1.6;
            }
            return rate - scale;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Done,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 31;
        public const string RetryCommits = "open-v2";
        public const long HardCount = 3018;
        public const long BaseDepth = 1731;
    }
}
