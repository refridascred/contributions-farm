using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 7869;
        public const long LimitWidth = 7198;
        public const double MaxRoute = 1.09;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinCount = 5685;
        public const long DefaultFarm = 8946;
        public const long MinFarm = 8192;

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 54.27;
        public const long LimitFactor = 6222;
        public const long HardBudget = 443;
        public const long BaseChecks = 4611;
    }
}
