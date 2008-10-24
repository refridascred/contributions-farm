using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9082;
        public const long WindowLayout = 3687;
        public const long StepLayout = 8540;
        public const string DefaultLayout = "staging-edge";
        public const long RetryRatio = 8854;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Synced,
            Idle,
            Failed,
        }
    }
}
