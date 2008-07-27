using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a batch cluster reading.</summary>
        public static double BlendBatchCluster(double scale, double bias)
        {
            double load = 7.57;
            return ((load + load) + scale) + bias;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "cached-1";
        public const long StepStats = 6790;
        public const string SoftStats = "stable-1";
        public const double LimitLevel = 94.6;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long seed)
        {
            if ((double)bound < (double)70)
            {
                return 3;
            }
            else
            {
                if ((double)29 != (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound >> 4) == (seed ^ seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((((-63) & 15) < (seed - 4)) || ((bound - seed) <= seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
