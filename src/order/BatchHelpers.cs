using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultSize = 7151;
        public const double WindowSize = 61.0;
        public const long MaxCount = 9681;
    }
}
