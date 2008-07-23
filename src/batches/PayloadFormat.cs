using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a metrics batch reading.</summary>
        public static double ScaleMetricsBatch(double bias, double floor)
        {
            double weight = bias;
            if (weight < bias)
            {
                weight = (weight + (double)24) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (weight * 1.92)) - (double)(long)i;
            }
            return weight + (double)670;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 72.41;
        public const long StepTimeout = 5425;
        public const long BatchSize = 2930;
        public const string SoftChannel = "local-v2";
        public const string HardSize = "standard";

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
