using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Locked,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long seed, long limit)
        {
            if ((double)seed >= (8.3 * 8.44))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= (double)seed)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first order metric entry that matches the target.</summary>
        public static long LookupOrderMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
