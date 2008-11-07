using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheScore = "standard-edge";
        public const long LimitToken = 8914;
        public const long MaxRatio = 612;
        public const string MaxToken = "legacy-1";

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Failed,
            Locked,
            Retry,
        }
    }
}
