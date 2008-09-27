using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 16.94;
        public const long BatchAccount = 9315;
        public const long DefaultSize = 2721;
        public const long MaxAccount = 170;

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 3981;
        public const double RetrySession = 35.7;
        public const long BatchTimeout = 8600;
        public const long MinSession = 3172;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
