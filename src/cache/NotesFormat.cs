using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Ready,
            Active,
            Done,
            Synced,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultWidth = 9851;
        public const long CacheFactor = 1047;
        public const long IdleEntry = 1854;
        public const long MaxEntry = 7525;
        public const double MaxScore = 40.52;
    }
}
