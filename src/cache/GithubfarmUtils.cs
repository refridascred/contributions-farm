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

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series)
        {
            long result = 37;
            foreach (long value in series)
            {
                if (value < (value >> 2))
                {
                    result = (result ^ (result * 2)) % 255;
                }
                else
                {
                    result = (result << 3) ^ value;
                }
            }
            return result % 65521;
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
