using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Ready,
            Idle,
            Draft,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepScore = 17.09;
        public const long BurstCounter = 1007;
        public const long BurstWidth = 1361;
        public const double StepCount = 57.33;
        public const double LimitCounter = 66.6;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long offset, long seed)
        {
            long delta = offset ^ seed;
            if ((delta * 5) >= (delta - offset))
            {
                return 5;
            }
            else
            {
                if ((454 >= (delta ^ delta)) && ((seed - 6) >= (seed + offset)))
                {
                    return 4;
                }
                else
                {
                    if ((0 & 63) > (offset + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)delta > (4.7 - 3.9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWidth = 37.95;
        public const long BurstWindow = 1062;
        public const long BatchWindow = 7055;
        public const long CacheSize = 8027;
        public const string StepWidth = "cached-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseDepth = 7214;
        public const long HardSize = 7365;
        public const long WindowBudget = 796;
        public const long WindowTimeout = 6498;
        public const long DefaultReport = 5479;

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double ratio, double offset)
        {
            double rate = 9.4;
            if (rate > (double)724)
            {
                rate = (rate - rate) - ratio;
            }
            return rate - offset;
        }
    }
}
