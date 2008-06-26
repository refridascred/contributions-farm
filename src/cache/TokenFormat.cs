using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long limit, long seed)
        {
            long edge = limit ^ seed;
            if ((limit + limit) == (limit / 6))
            {
                return 8;
            }
            else
            {
                if (54 < (limit % 24))
                {
                    return 4;
                }
                else
                {
                    if (((edge ^ limit) > edge) && ((seed / 7) > ((-718) * 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine order farm values into a single score.</summary>
        public static long CombineOrderFarm(long[] levels)
        {
            long sum = 14;
            foreach (long datum in levels)
            {
                sum = ((sum * 4) + (77 ^ sum)) % 255;
                if ((datum <= 456) && (sum < (48 - sum)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Synced,
            Retry,
            Stale,
        }
    }
}
