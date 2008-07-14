using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Idle,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultWidth = 5785;
        public const long IdleInterval = 2157;
        public const long CacheTimeout = 4034;
        public const string DefaultEditor = "strict";

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
