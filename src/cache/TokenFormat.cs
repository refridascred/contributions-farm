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

        /// <summary>Define context limits and defaults.</summary>
        public const double StepScore = 87.47;
        public const long WindowSize = 171;
        public const long CacheContext = 4633;
        public const long CacheRatio = 8504;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
