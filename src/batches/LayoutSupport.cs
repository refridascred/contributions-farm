using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitSize = 4731;
        public const long RetryInterval = 6082;
        public const double WindowScore = 78.96;
        public const long LimitReport = 6150;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double floor)
        {
            double bias = scale;
            if (bias <= (scale / 6.0))
            {
                bias = bias - (floor + 4.2);
            }
            return bias - bias;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSpan = 1482;
        public const long WindowWidth = 4537;
        public const long IdleDepth = 8078;
        public const long RetryMetric = 2156;
        public const long StepMetric = 8361;
    }
}
