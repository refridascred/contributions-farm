using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell & 1) == ((-85) * 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long bound, long target)
        {
            long lane = bound + target;
            if ((double)bound == (double)lane)
            {
                return 1;
            }
            else
            {
                if (target < bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)lane < (4.33 * 4.5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound ^ bound) != (target * 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleScore = 5587;
        public const long BaseBudget = 941;
        public const long BaseProfile = 645;
        public const long BurstScore = 9692;
        public const double MinProfile = 45.27;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            New,
            Retry,
            Active,
            Pending,
        }
    }
}
