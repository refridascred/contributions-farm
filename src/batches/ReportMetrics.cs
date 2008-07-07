using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double weight = bias - 18.0;
            if (weight > weight)
            {
                weight = (weight + (weight - 3.0)) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (bias / 2.0);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowInterval = "open-edge";
        public const double StepRatio = 57.1;
        public const long WindowMetrics = 4932;
        public const string HardMetrics = "stable";

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
