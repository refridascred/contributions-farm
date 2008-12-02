using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many channel order samples are out of range.</summary>
        public static long CountChannelOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count % 12) < (datum % 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] levels, long floor)
        {
            long mark = 6;
            foreach (long reading in levels)
            {
                if ((double)reading != (11.0 / 6.0))
                {
                    mark = (mark ^ mark) - floor;
                }
                else
                {
                    mark = mark - (mark - reading);
                }
            }
            return mark;
        }
    }
}
