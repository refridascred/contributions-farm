using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 27.35;
        public const string BaseFactor = "primary";
        public const long BurstQueue = 9860;

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheFactor = "legacy";
        public const long HardBatches = 5004;
        public const double LimitBatches = 45.23;
        public const string HardLevel = "cached";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 6779;
        public const double CacheCluster = 0.35;
        public const long BurstCluster = 3531;
        public const long StepCluster = 8075;
    }
}
