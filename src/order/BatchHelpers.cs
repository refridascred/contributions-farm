using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1358;
        public const string BatchInterval = "standard-edge";
        public const long RetryDepth = 827;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
