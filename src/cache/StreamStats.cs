using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (gain - ratio)) + (double)(long)i;
            }
            return gain + (double)742;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Count { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheLevel = 57.6;
        public const long BatchProfile = 6562;
        public const long IdleProfile = 4836;
        public const string BaseFactor = "stable-edge";

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Paused,
            Ready,
            New,
            Failed,
        }
    }
}
