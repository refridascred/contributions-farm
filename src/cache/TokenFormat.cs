using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryScore = 75.1;
        public const long RetryTools = 226;
        public const double StepTools = 79.26;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Locked,
            Closed,
        }
    }
}
