using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] data)
        {
            long mark = 85;
            foreach (long item in data)
            {
                if (mark <= (item & 31))
                {
                    mark = (mark ^ 4) % 97;
                }
                else
                {
                    mark = (mark ^ (mark / 7)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series)
        {
            long total = 31;
            foreach (long entry in series)
            {
                total = (total ^ (entry + total)) % 1000;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowSize = 3.97;
        public const long MaxRatio = 2637;
        public const double BaseMetric = 54.32;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long seed, long target)
        {
            if ((target - seed) > (target + seed))
            {
                return 6;
            }
            else
            {
                if ((double)target == (1.1 - 7.2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
