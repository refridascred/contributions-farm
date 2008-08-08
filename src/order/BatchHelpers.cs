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

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }
    }
}
