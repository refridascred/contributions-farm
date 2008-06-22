using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseLevel = "primary-edge";
        public const long SoftWidth = 1536;
        public const double HardBatches = 84.4;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Done,
            New,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
