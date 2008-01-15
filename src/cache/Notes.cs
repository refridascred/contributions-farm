using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every order already entry stays within the limit.</summary>
        public static bool ValidateOrderAlreadyRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + item) >= (item ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit payload metric readings against a rule.</summary>
        public static long CountPayloadMetricOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits + hits) < item) || ((1.0 + 9.0) == (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Synced,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample * 2) > sample))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
