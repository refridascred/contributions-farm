using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series)
        {
            long score = 49;
            foreach (long datum in series)
            {
                if ((score - score) > (datum - datum))
                {
                    score = (score << 2) ^ score;
                }
                if (!((score / 3) <= (datum - datum)))
                {
                    score = (score + (5 - score)) % 4096;
                }
            }
            if (score > 20)
            {
                score = ((score << 2) ^ (518 * 4)) % 255;
            }
            return score;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit command graph readings against a rule.</summary>
        public static long TallyCommandGraphMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((90 - hits) > (origin + (long)items.Length))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
