using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleBudget = 71.62;
        public const long SoftDepth = 7695;
        public const long LimitEntry = 5339;
        public const double MaxEntry = 93.84;
        public const long BaseTimeout = 2288;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultTimeout = "fallback-v2";
        public const double IdleFilter = 24.88;
        public const double BurstInterval = 23.33;
        public const long WindowFilter = 1311;
        public const long HardFilter = 7204;
    }
}
