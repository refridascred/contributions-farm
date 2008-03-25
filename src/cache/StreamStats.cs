using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Idle,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCount = 9500;
        public const double CacheFactor = 29.32;
        public const double CacheTimeout = 32.36;
        public const long CacheScore = 103;
        public const long IdleCounter = 4041;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
