using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 5127;
        public const string StepEntry = "stable";
        public const double IdleEntry = 4.1;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            New,
            Failed,
            Synced,
            Retry,
        }
    }
}
