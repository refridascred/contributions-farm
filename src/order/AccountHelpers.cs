using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleCount = "staging-1";
        public const double MaxSpan = 42.06;
        public const long MinFarm = 9526;
        public const long StepCount = 5654;
        public const string BaseSize = "latest-v2";

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

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Ready,
            New,
            Synced,
            Done,
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
