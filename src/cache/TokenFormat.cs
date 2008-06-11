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

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Active,
            Ready,
        }
    }
}
