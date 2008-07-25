using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 9380;
        public const long MaxRatio = 5341;
        public const double MaxBatch = 32.34;
        public const long CacheBatch = 4508;
        public const long CacheWidth = 343;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = total + ((long)i + (long)i);
                if (total > (1 + floor))
                {
                    total = (total - floor) % 255;
                    total = (total * 3) + (total ^ floor);
                }
                else
                {
                    total = (total * 4) + floor;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 25.2;
        public const long RetryCount = 8088;
        public const double SoftInterval = 49.6;
    }
}
