using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 5842;
        public const string LimitBuffer = "legacy-v2";
        public const long IdleDepth = 2782;
        public const string IdleRatio = "staging-1";
        public const long StepBuffer = 5783;

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double bias, double span)
        {
            double weight = bias - (bias * 7.0);
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (span - weight)) + (double)(long)i;
            }
            return weight + 8.58;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
