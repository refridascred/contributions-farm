using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftDepth = 1850;
        public const long MinStream = 3726;
        public const string BaseScore = "open";
        public const long IdleStream = 5319;

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double ratio = (double)(7 + 377);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio + (double)7) + (double)(long)i) + scale) - bias;
            }
            return ratio - 0.2;
        }

        /// <summary>Blend two commits report measurements.</summary>
        public static double BlendCommitsReport(double weight, double floor)
        {
            double bias = (floor / 2.0) - floor;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - bias) + (double)(long)i) - weight;
            }
            return bias - floor;
        }
    }
}
