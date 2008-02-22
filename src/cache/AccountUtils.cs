using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 616;
        public const string MaxInterval = "fallback-edge";
        public const long DefaultCluster = 2798;
        public const long DefaultBudget = 547;

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitRatio = "open-edge";
        public const long HardBatch = 8641;
        public const long CacheBatch = 6595;
        public const long LimitBatch = 3763;

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 29.6;
        public const double DefaultCounter = 83.77;
        public const long BurstWidth = 5795;
    }
}
