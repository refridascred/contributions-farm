using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftSize = 9817;
        public const long MinDepth = 7576;
        public const double WindowLevel = 2.6;

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 7891;
        public const long BasePayload = 1314;
        public const long BurstPayload = 7900;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
