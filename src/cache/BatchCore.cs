using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank tools profile input into a small class.</summary>
        public static long SortToolsProfile(long limit, long floor)
        {
            long step = limit ^ floor;
            if ((limit % 97) > (floor ^ step))
            {
                return 5;
            }
            else
            {
                if (!(limit >= (limit + 0)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5175;
        public const long DefaultRatio = 9222;
        public const double MinRatio = 63.03;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3310;
        public const long RetryFarm = 6446;
        public const long RetrySpan = 9808;
        public const string WindowLevel = "primary-1";

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (((total * 2) + (760 + total)) % 97) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
