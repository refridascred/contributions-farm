using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 9586;
        public const double WindowRatio = 46.18;
        public const double MinWidth = 61.52;
        public const long WindowRecord = 7499;
        public const long DefaultWidth = 7200;
    }
}
