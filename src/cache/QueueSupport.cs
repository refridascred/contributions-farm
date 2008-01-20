using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Draft,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Idle,
            Active,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
