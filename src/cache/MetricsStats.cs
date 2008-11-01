using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 5804;
        public const long RetryFactor = 7942;
        public const long WindowLevel = 6100;

        /// <summary>Adjust a stats layout reading.</summary>
        public static double BlendStatsLayout(double ratio, double bias)
        {
            double bias2 = (double)(55 + 2);
            if (bias2 <= (2.0 - ratio))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (double)961;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (2.35 * 7.1);
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }
    }
}
