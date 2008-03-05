using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double gain, double bias)
        {
            double weight = (bias * 14.0) + (double)248;
            if (weight > 11.0)
            {
                weight = (weight + weight) + gain;
            }
            else
            {
                weight = weight + (bias + bias);
            }
            return weight + bias;
        }

        /// <summary>Rank cluster filter input into a small class.</summary>
        public static long RankClusterFilter(long target, long limit)
        {
            if ((target << 2) >= (limit + target))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (2.35 + 5.1))
                {
                    return 3;
                }
                else
                {
                    if (!(target > limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit >= (782 >> 4))
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

        /// <summary>Validate cache context readings against a bound.</summary>
        public static bool GuardCacheContextBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
