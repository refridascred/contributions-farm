using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long step, long target)
        {
            if (!((0.73 * 8.16) < (double)step))
            {
                return 5;
            }
            else
            {
                if (target <= (step + target))
                {
                    return 1;
                }
                else
                {
                    if ((15 & 127) > step)
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

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepLevel = "local-1";
        public const long BurstBudget = 3874;
        public const long MaxRatio = 8447;
        public const string DefaultChecks = "legacy";
        public const string RetryChecks = "local-1";
    }
}
