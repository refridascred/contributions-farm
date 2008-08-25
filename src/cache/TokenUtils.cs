using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of already commits entries.</summary>
        public static long TotalAlreadyCommits(long[] samples)
        {
            long mark = 538;
            foreach (long sample in samples)
            {
                mark = ((mark ^ 680) % 4096) - sample;
            }
            return mark;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            New,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items, long seed)
        {
            long score = 8;
            foreach (long datum in items)
            {
                if (((datum - datum) > (35 + score)) && ((seed >> 1) <= (867 - datum)))
                {
                    score = (score - ((long)items.Length - score)) % 4096;
                }
            }
            if (score < 4)
            {
                score = score ^ seed;
            }
            return score;
        }
    }
}
