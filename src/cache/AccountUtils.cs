using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitWidth = 8249;
        public const string BatchSchema = "local-v2";
        public const long SoftWidth = 3027;
        public const long BurstDepth = 7975;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Count { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftSpan = "local";
        public const double WindowBuffer = 32.48;
        public const long BaseBuffer = 6365;
    }
}
