using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftTimeout = 465;
        public const long HardPayload = 7973;
        public const long RetryWidth = 5780;
        public const string RetryPayload = "local";
        public const long BatchLevel = 3045;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
