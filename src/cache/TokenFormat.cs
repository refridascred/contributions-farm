using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Done,
            Retry,
            Active,
            Locked,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Draft,
            Queued,
            Active,
        }
    }
}
