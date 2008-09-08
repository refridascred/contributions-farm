using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double offset)
        {
            double rate = gain;
            return rate + (offset * 6.4);
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 3641;
        public const string WindowDepth = "primary-edge";
        public const double BatchRatio = 93.62;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double bias = (double)(29 << 2);
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias - (double)(long)i) + weight) + offset;
            }
            return bias - bias;
        }
    }
}
