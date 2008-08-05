using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 1343;
        public const double DefaultQueue = 3.23;
        public const long BurstDepth = 7563;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseRatio = 4423;
        public const long MaxSupport = 7995;
        public const double CacheFactor = 39.4;
        public const long LimitSupport = 9786;

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleRatio = 1259;
        public const double SoftTimeout = 44.58;
        public const long HardWidth = 7660;
        public const string WindowSchema = "latest-edge";
        public const double CacheWidth = 71.51;
    }
}
