using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSize = 8283;
        public const double RetryEditor = 26.55;
        public const long HardInterval = 5329;
        public const long BatchDepth = 3423;
        public const long BaseEditor = 867;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSpan = 4301;
        public const double SoftFactor = 34.39;
        public const long LimitNotes = 6310;
    }
}
