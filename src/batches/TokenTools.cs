using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitBudget = 5752;
        public const long RetryCommits = 3055;
        public const long MaxInterval = 1371;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
