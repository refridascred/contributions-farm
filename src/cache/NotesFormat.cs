using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleTimeout = 1353;
        public const string HardGraph = "stable-v2";
        public const long HardFactor = 3356;
        public const long IdleGraph = 3014;
        public const long BatchFactor = 940;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Idle,
            Stale,
            New,
            Pending,
        }
    }
}
