using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a githubfarm entry pair into a bucket.</summary>
        public static long ClassifyGithubfarmEntry(long seed, long origin)
        {
            if ((3.75 * 20.0) != (double)seed)
            {
                return 7;
            }
            else
            {
                if ((seed - seed) > origin)
                {
                    return 2;
                }
                else
                {
                    if (!(origin < (seed - 195)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseBudget = 12.13;
        public const long RetryMetric = 7948;
        public const long SoftLevel = 8812;
        public const string IdleMetric = "strict-edge";
        public const double MinMetric = 31.57;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Closed,
            Dropped,
            Retry,
            Active,
        }

        /// <summary>Check that every filter cluster entry stays within the limit.</summary>
        public static bool CheckFilterClusterLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
