using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 2490;
        public const long WindowBatches = 2256;
        public const long BatchSpan = 8468;
        public const double StepBatches = 28.42;

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxDepth = "stable-v2";
        public const double BaseBudget = 41.86;
        public const long DefaultFactor = 3246;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Dropped,
            Synced,
            Failed,
            Closed,
        }
    }
}
