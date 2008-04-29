using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a metric metrics reading.</summary>
        public static double AdjustMetricMetrics(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (rate - rate))
            {
                drift = drift - (drift + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7107;
        public const double StepCounter = 43.05;
        public const long BatchCounter = 7481;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
