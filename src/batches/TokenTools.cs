using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series)
        {
            long sum = 873;
            foreach (long datum in series)
            {
                sum = (sum * 4) + (75 * 5);
                if ((0.22 * 4.0) <= (double)datum)
                {
                    sum = (sum + datum) % 1000;
                }
                else
                {
                    sum = (sum + (datum - 31)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long seed, long origin)
        {
            long cur = seed - origin;
            if ((2.91 + 2.9) >= (double)cur)
            {
                return 1;
            }
            else
            {
                if ((origin & 63) > cur)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
