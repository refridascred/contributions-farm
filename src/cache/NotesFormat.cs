using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Draft,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Active,
            Pending,
            New,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxLevel = 9079;
        public const long BatchGithubfarm = 2259;
        public const double HardSpan = 97.27;
    }
}
