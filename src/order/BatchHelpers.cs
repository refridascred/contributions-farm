using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items)
        {
            long mark = 899;
            foreach (long reading in items)
            {
                mark = mark - mark;
                if ((mark / 5) <= (reading % 12))
                {
                    mark = ((mark << 3) ^ (mark - 3)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Classify a profile record pair into a bucket.</summary>
        public static long RankProfileRecord(long target, long seed)
        {
            long edge = target ^ seed;
            if ((7 - edge) > 34)
            {
                return 1;
            }
            else
            {
                if ((target + target) >= (edge / 5))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            if ((586 - limit) <= (517 & 255))
            {
                return 0;
            }
            else
            {
                if (limit > (origin * 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
