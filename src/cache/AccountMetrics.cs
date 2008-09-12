using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultTimeout = "latest-1";
        public const long WindowContext = 880;
        public const long BurstContext = 3817;
        public const long IdleContext = 8604;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double span)
        {
            double ratio = (double)(481 % 100);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)(long)i) - span;
            }
            return ratio + (weight - ratio);
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Iterate the metric cluster series from a seed.</summary>
        public static long RollMetricCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum + origin) % 1000) + (long)i2;
                }
                sum = (sum - (sum + origin)) % 255;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Stale,
            Dropped,
            Ready,
            Active,
        }
    }
}
