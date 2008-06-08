using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 9316;
        public const double CacheFactor = 4.7;
        public const long BurstFactor = 7061;
        public const long CacheLevel = 4087;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 2519;
        public const long MaxSize = 9837;
        public const long WindowCount = 1996;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
