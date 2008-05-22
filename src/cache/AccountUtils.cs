using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseCount = 8324;
        public const long SoftProfile = 8319;
        public const long WindowProfile = 167;
        public const long BaseProfile = 1716;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryRatio = 1519;
        public const double RetryWidth = 91.66;
        public const long BurstSchema = 493;

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i / 6) >= limit)
                {
                    result = (result << 3) ^ (limit + limit);
                }
                result = (result ^ (limit - 966)) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
