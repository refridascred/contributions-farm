using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 7824;
        public const double SoftLevel = 85.19;
        public const long CacheEntry = 5345;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSpan = 6144;
        public const long MaxCount = 9810;
        public const string MaxDepth = "standard";
        public const long SoftBuffer = 1752;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Queued,
            Retry,
            Stale,
        }
    }
}
