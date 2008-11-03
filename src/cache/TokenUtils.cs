using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 1274;
        public const long LimitBudget = 1717;
        public const long DefaultContext = 8309;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 2963;
        public const long CacheWidth = 7941;
        public const long BurstRecord = 6023;
        public const string HardFactor = "fallback-1";
        public const long BatchRecord = 8183;
    }
}
