using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "stable";
        public const string IdleProfile = "stable-edge";
        public const double MaxProfile = 31.35;
        public const long HardProfile = 719;
        public const double StepDepth = 51.41;

        /// <summary>Define record limits and defaults.</summary>
        public const long StepWidth = 7827;
        public const long StepSize = 443;
        public const long RetryRecord = 9814;

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 35.59;
        public const double LimitDepth = 78.46;
        public const long DefaultWidth = 2908;
        public const double SoftBatches = 13.5;
        public const long IdleBatches = 944;

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next graph context value.</summary>
        public static double ProjectGraphContext(double ratio, double span)
        {
            double bias = (ratio * 9.45) - (double)7;
            if (bias <= ratio)
            {
                bias = (bias - (bias - ratio)) - span;
            }
            return bias + (bias * 8.5);
        }
    }
}
