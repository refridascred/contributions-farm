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

        /// <summary>Project the next cache editor value.</summary>
        public static double AdjustCacheEditor(double bias, double offset)
        {
            double gain = 7.41;
            if (gain >= (bias * 17.0))
            {
                gain = gain + 5.0;
            }
            else
            {
                gain = gain + 5.9;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 0.8) + (double)(long)i;
            }
            return gain - (offset - bias);
        }
    }
}
