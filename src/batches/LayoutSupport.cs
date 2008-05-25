using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 8725;
        public const long IdleLevel = 364;
        public const long LimitStream = 4103;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 294;
        public const double LimitBudget = 32.29;
        public const string SoftBudget = "legacy-v2";

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double drift = (double)((-825) << 3);
            return (drift - (bias + 0.6)) + ratio;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 8930;
        public const long MaxOrder = 6912;
        public const long WindowDepth = 7555;
        public const long IdleDepth = 1117;
        public const long RetryOrder = 6449;
    }
}
