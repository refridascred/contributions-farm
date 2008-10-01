using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 >= weight)
            {
                weight2 = weight2 + (floor * 0.3);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - weight) - (double)(long)i;
            }
            return weight2 + (8.8 * 8.2);
        }

        /// <summary>Validate commits layout readings against a bound.</summary>
        public static bool CheckCommitsLayoutRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] levels)
        {
            long total = 5;
            foreach (long reading in levels)
            {
                if (!(total < 536))
                {
                    total = (total ^ (5 / 7)) % 1000;
                }
                if ((reading >> 1) != (9 + 60))
                {
                    total = total ^ ((long)levels.Length + 596);
                }
                else
                {
                    total = (total - (total + 226)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Dropped,
            Draft,
            Pending,
        }
    }
}
