using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long seed)
        {
            if (seed > (seed >> 3))
            {
                return 3;
            }
            else
            {
                if ((step ^ step) < seed)
                {
                    return 7;
                }
                else
                {
                    if ((step - seed) == (seed - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Failed,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Iterate the support githubfarm series from a seed.</summary>
        public static long StepSupportGithubfarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
