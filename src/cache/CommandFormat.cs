using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            New,
            Ready,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Paused,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxSize = 59.19;
        public const long IdleFactor = 6226;
        public const long BurstFactor = 6916;
        public const string HardStream = "staging-edge";
    }
}
