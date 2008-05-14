using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark << 2) ^ (bound >> 5)) % 101;
                mark = mark - (mark - 435);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] readings)
        {
            long mark = -163;
            foreach (long datum in readings)
            {
                if (0.1 > (double)mark)
                {
                    mark = ((mark * 3) + datum) % 255;
                }
                else
                {
                    mark = (mark ^ (mark + datum)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Active,
            Done,
        }
    }
}
