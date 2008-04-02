using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long limit, long target)
        {
            if ((limit + target) != (target >> 2))
            {
                return 4;
            }
            else
            {
                if (((double)target >= (9.9 - 9.16)) && (18 < (target << 1)))
                {
                    return 3;
                }
                else
                {
                    if ((target + limit) >= 114)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long carry = 62;
            foreach (long item in readings)
            {
                if ((item * 2) < carry)
                {
                    carry = (carry + (item - 195)) % 1000;
                }
            }
            if (carry > (-270))
            {
                carry = carry + (carry & 7);
            }
            return carry % 1000;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)154 <= (double)cell)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi queue entries.</summary>
        public static long FoldContributiQueue(long[] data, long floor)
        {
            long mark = 87;
            foreach (long sample in data)
            {
                mark = ((mark ^ floor) % 65521) + sample;
            }
            if (mark < 66)
            {
                mark = mark ^ (48 - mark);
            }
            return mark % 4096;
        }
    }
}
