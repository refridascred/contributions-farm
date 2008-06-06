using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftInterval = 6224;
        public const long MaxScore = 1565;
        public const double BaseBatches = 38.4;
        public const long SoftLevel = 2095;
        public const long CacheBudget = 1107;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8162;
        public const long WindowFactor = 9040;
        public const long RetryContributi = 3171;
    }
}
