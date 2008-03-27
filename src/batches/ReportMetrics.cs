using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepBudget = 2903;
        public const long BurstGithubfarm = 9720;
        public const long RetryGithubfarm = 5875;
        public const double StepGithubfarm = 15.95;
        public const double RetryDepth = 95.06;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Locked,
            New,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long step, long limit)
        {
            long next = step + limit;
            if ((double)step > (13.0 + 8.7))
            {
                return 4;
            }
            else
            {
                if ((next + (-325)) > next)
                {
                    return 2;
                }
                else
                {
                    if ((next ^ limit) == (next + step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
