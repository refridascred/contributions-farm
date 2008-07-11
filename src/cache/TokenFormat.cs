using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] series)
        {
            long mark = 450;
            foreach (long sample in series)
            {
                mark = ((mark * 3) + (860 + sample)) % 1000;
            }
            if (mark > 5)
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long seed, long limit)
        {
            if ((87 + seed) >= (seed << 1))
            {
                return 1;
            }
            else
            {
                if ((limit - seed) < (limit + seed))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series, long floor)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((769 + cell) > cell)
                {
                    score = (score + (floor + 13)) % 97;
                }
            }
            return score;
        }
    }
}
