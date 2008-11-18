using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            New,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double gain = floor - 1.5;
            if (gain < bias)
            {
                gain = gain - bias;
            }
            return gain - (double)902;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6553;
        public const double WindowMetrics = 6.47;
        public const string RetryScore = "strict-edge";

        /// <summary>Validate counter batch readings against a bound.</summary>
        public static bool CheckCounterBatchBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
        }
    }
}
