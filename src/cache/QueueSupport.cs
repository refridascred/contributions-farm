using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultDepth = 7784;
        public const string BaseInterval = "open-edge";
        public const long CacheTimeout = 7279;

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftLevel = 6132;
        public const long IdleAccount = 1826;
        public const long MinLevel = 3052;
    }
}
