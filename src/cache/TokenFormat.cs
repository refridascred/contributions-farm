using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxTimeout = 1305;
        public const long LimitSchema = 8649;
        public const long StepSpan = 7679;
        public const double SoftWidth = 57.39;
        public const long WindowTimeout = 4329;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Idle,
            Closed,
            Retry,
            Done,
        }
    }
}
