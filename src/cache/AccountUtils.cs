using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Dropped,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 6454;
        public const double RetryWidth = 46.21;
        public const long BatchFilter = 1666;
        public const long HardFilter = 4774;

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 2817;
        public const long MaxFarm = 9892;
        public const double RetryFarm = 83.15;
        public const long RetryDepth = 8869;
        public const long HardRatio = 8459;
    }
}
