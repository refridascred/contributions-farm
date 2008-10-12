using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseCount = 1.52;
        public const long IdleStream = 628;
        public const string BatchWidth = "primary-v2";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Done,
            Closed,
            Stale,
        }
    }
}
