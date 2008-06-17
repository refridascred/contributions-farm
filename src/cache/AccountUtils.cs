using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Ready,
            Draft,
            New,
            Queued,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long seed)
        {
            long bound = step - seed;
            if ((step + step) != (bound << 1))
            {
                return 7;
            }
            else
            {
                if ((step * 3) <= seed)
                {
                    return 4;
                }
                else
                {
                    if ((step + 901) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item - tally) <= (tally << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
