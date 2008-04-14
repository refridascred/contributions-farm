using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 - (bias2 * 7.64)) + bias;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a window format reading.</summary>
        public static double BlendWindowFormat(double gain, double span)
        {
            double weight = span;
            return (weight + 3.0) + gain;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseFactor = 3328;
        public const long BatchWidth = 4264;
        public const long HardSession = 9861;
        public const long IdleWidth = 6827;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Locked,
            Retry,
        }
    }
}
