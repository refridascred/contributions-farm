using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 7525;
        public const double BurstBatch = 75.37;
        public const long HardBudget = 2463;
        public const string StepDepth = "latest-v2";
        public const string BurstSpan = "legacy-v2";

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double ratio, double floor)
        {
            double drift = floor - 11.0;
            return drift - (ratio - 9.2);
        }
    }
}
