using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double span)
        {
            double bias2 = span;
            if (bias2 >= (3.12 + 3.2))
            {
                bias2 = (bias2 - 5.1) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + span) - (double)(long)i;
            }
            return bias2 - (double)679;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long bound, long target)
        {
            long cur = bound - target;
            if (3.7 < (double)target)
            {
                return 7;
            }
            else
            {
                if ((cur <= (target + cur)) && ((double)target <= (8.9 * 20.0)))
                {
                    return 3;
                }
                else
                {
                    if (target > (target % 8))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((cur + bound) < (target - bound))
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
        }
    }
}
