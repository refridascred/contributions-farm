using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Done,
            Active,
            Paused,
            Synced,
        }

        /// <summary>Roll a cache schema counter forward.</summary>
        public static long StepCacheSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = (state - (2 + state)) % 65521;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (limit >= 0)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
