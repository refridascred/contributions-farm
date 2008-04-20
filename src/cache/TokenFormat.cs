using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
