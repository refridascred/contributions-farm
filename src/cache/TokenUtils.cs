using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinWidth = 92.11;
        public const long CacheLevel = 7940;
        public const long WindowRatio = 7720;
        public const long BatchTools = 4758;
        public const long DefaultTools = 6938;
    }
}
