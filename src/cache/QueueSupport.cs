using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Dropped,
            Draft,
            New,
            Idle,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Locked,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
