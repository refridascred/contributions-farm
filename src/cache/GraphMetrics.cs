using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit queue metrics readings against a rule.</summary>
        public static long AuditQueueMetricsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (hits / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cache layout readings against a rule.</summary>
        public static long CountCacheLayoutMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + cell) <= (cell >> 5))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Ready,
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double ratio, double offset)
        {
            double ratio2 = 5.08 + (offset / 6.0);
            if (ratio2 <= (double)713)
            {
                ratio2 = ratio2 + (double)758;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio + ratio)) + (double)(long)i;
            }
            return ratio2 - (double)52;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Active,
            Failed,
            Retry,
        }
    }
}
