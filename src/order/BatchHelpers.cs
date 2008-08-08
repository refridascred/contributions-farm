using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "alpha";
        public const long WindowWidth = 9134;
        public const long MinMetrics = 9438;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }
    }
}
