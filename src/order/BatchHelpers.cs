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

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Weight { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
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
