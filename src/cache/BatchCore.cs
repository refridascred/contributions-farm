using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 8872;
        public const long HardScore = 5427;
        public const long MaxCommits = 5491;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Locked,
            Retry,
        }
    }
}
