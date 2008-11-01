using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 8292;
        public const double LimitBudget = 95.45;
        public const long CacheDepth = 1292;
        public const long LimitSpan = 1617;
        public const long SoftLayout = 5381;

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheBudget = "open-edge";
        public const long DefaultScore = 6096;
        public const long IdleInterval = 2002;
        public const long MaxFactor = 8383;
        public const double LimitWidth = 4.8;

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "primary";
        public const long BurstAccount = 3903;
        public const long SoftBudget = 2055;
        public const double BatchAccount = 64.23;
        public const long IdleAccount = 3844;
    }
}
