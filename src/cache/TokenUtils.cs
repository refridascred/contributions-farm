using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "fallback-1";
        public const string IdleWidth = "cached";
        public const double BaseDepth = 75.33;
        public const long RetryDepth = 8795;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Paused,
            Retry,
        }
    }
}
