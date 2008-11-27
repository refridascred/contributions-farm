using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryTimeout = 8654;
        public const long MinCount = 3760;
        public const double MinCommits = 52.44;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSize = 2998;
        public const long DefaultCache = 6541;
        public const string BaseCount = "cached-v2";
        public const string BaseCache = "local-v2";
    }
}
