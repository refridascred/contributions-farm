using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark + ((long)i >> 2)) - (long)i2;
                }
                mark = (mark * 2) + (long)i;
                mark = (mark ^ (mark >> 1)) % 4096;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] items, long offset)
        {
            long mix = 143;
            foreach (long value in items)
            {
                mix = (mix - (mix + value)) % 255;
            }
            if (mix < 71)
            {
                mix = ((mix << 3) ^ (3 + offset)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Locked,
            Stale,
            Queued,
            Done,
        }
    }
}
