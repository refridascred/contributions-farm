using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (9.69 < (double)count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] series)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                if ((double)mix <= (6.91 * 5.78))
                {
                    mix = ((mix - mix) % 1000) ^ datum;
                }
            }
            if (mix > 80)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Measure how many metric stream samples are out of range.</summary>
        public static long CountMetricStreamOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item > (double)hits)
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Paused,
            Idle,
            Synced,
        }
    }
}
