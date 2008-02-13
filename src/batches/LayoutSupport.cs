using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxLevel = 2.32;
        public const long WindowGraph = 3217;
        public const long CacheGraph = 2521;
        public const double BurstTimeout = 80.85;
        public const long HardCount = 3719;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double span)
        {
            double mean = (double)47 * 0.76;
            return ((mean + (19.0 * 6.43)) + weight) + span;
        }
    }
}
