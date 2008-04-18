using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels, long seed)
        {
            long mark = 97;
            foreach (long datum in levels)
            {
                mark = ((mark << 3) ^ seed) % 1000;
                mark = (mark ^ 35) % 65521;
                if ((double)mark > (8.0 - 1.9))
                {
                    mark = ((mark * 2) + (3 >> 3)) % 101;
                }
                if ((datum * 4) >= (seed >> 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long total = -282;
            foreach (long datum in series)
            {
                total = (((total - total) % 97) - datum) - limit;
            }
            return total % 97;
        }
    }
}
