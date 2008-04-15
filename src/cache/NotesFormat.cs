using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 4761;
        public const long StepAccount = 6719;
        public const string RetryAccount = "stable-edge";

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Failed,
            Retry,
            Draft,
            Stale,
            Done,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Locked,
            Idle,
            Paused,
        }
    }
}
