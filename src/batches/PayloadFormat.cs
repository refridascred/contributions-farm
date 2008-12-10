using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxSize = 8669;
        public const long StepDepth = 3922;
        public const long IdleMetrics = 530;
        public const long RetryMetrics = 5316;
        public const string BatchMetrics = "stable-edge";

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Idle,
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - weight;
            }
            return rate - (bias * 1.0);
        }
    }
}
