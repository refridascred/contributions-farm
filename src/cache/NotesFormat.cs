using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            New,
            Queued,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 7913;
        public const long BaseFactor = 8711;
        public const string DefaultInterval = "primary-1";
        public const long IdleLevel = 1775;
        public const string IdleTimeout = "legacy-edge";

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            New,
            Locked,
            Closed,
            Dropped,
        }
    }
}
