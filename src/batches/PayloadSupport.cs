using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseDepth = 9858;
        public const string IdleDepth = "staging-1";
        public const long RetryCount = 163;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
