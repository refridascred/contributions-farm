using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batch buffer value from a seed.</summary>
        public static long IterateBatchBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark + (467 % 60)) % 1000;
                mark = (mark ^ (208 - mark)) % 65521;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples)
        {
            long mark = 838;
            foreach (long sample in samples)
            {
                mark = (((mark << 2) ^ (mark - mark)) % 65521) ^ sample;
            }
            if (mark < 816)
            {
                mark = mark + mark;
            }
            return mark % 1000;
        }
    }
}
