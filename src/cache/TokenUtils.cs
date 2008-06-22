using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepTimeout = 4626;
        public const long MinSize = 2918;
        public const string BatchBudget = "stable-edge";
        public const long StepBuffer = 8093;
        public const double RetryFactor = 25.36;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double gain, double floor)
        {
            double mean = gain;
            if (mean < (floor + 7.0))
            {
                mean = mean - floor;
            }
            return mean + gain;
        }
    }
}
