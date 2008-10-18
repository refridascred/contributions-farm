using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "open-edge";
        public const long RetryTimeout = 3568;
        public const long WindowPayload = 5715;
        public const double MaxBudget = 78.26;
        public const long DefaultPayload = 352;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleLevel = 76.32;
        public const double BatchCluster = 79.54;
        public const double MinCluster = 54.39;
        public const long CacheSpan = 6790;
        public const long HardCount = 6485;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 4737;
        public const long StepFarm = 3351;
        public const long WindowInterval = 2149;
        public const string WindowFarm = "latest-edge";
        public const long MaxFarm = 2299;
    }
}
