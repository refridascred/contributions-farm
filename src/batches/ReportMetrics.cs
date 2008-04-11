using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowRatio = 7905;
        public const long WindowBatches = 9387;
        public const string BurstBudget = "alpha-edge";
        public const string MinBatches = "legacy";
        public const long IdleFactor = 2219;

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double scale = weight * 8.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + weight) + (double)(long)i) + floor;
            }
            return scale - (11.0 * 20.0);
        }
    }
}
