using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 2368;
        public const double SoftSize = 43.79;
        public const double BaseDepth = 36.42;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Active,
            New,
            Stale,
        }
    }
}
