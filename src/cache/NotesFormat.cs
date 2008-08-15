using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Retry,
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 38.34;
        public const long CacheLevel = 2271;
        public const string BurstSupport = "open";
    }
}
