using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "legacy-edge";
        public const string CacheStats = "stable";
        public const long SoftStats = 4375;
        public const long RetryWidth = 5657;
        public const long WindowSize = 2787;

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxRatio = "alpha-1";
        public const long SoftScore = 8243;
        public const string StepFilter = "open";

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double bias)
        {
            double weight = 5.61;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - weight) - (double)(long)i) + bias;
            }
            return weight - ratio;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
