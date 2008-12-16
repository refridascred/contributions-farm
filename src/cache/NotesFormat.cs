using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Retry,
            New,
            Idle,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepInterval = 9280;
        public const string WindowBuffer = "stable-v2";
        public const double BaseSize = 94.04;
        public const long HardBuffer = 5179;
    }
}
