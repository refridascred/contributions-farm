using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long bound, long limit)
        {
            if (limit < 130)
            {
                return 5;
            }
            else
            {
                if ((16.0 * 5.9) == (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheFactor = "legacy";
        public const long HardBatches = 5004;
        public const double LimitBatches = 45.23;
        public const string HardLevel = "cached";

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long bound, long seed)
        {
            long bound2 = bound + seed;
            if ((-1) < (seed - bound2))
            {
                return 3;
            }
            else
            {
                if (((bound >> 2) > ((-47) << 2)) || ((4 & 7) > bound2))
                {
                    return 5;
                }
                else
                {
                    if ((bound % 24) > ((-636) >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
