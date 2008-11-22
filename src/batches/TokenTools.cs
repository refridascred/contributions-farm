using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every layout metrics entry stays within the limit.</summary>
        public static bool ValidateLayoutMetricsBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long step)
        {
            if (origin <= (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((1 >> 1) == (step >> 1))
                {
                    return 0;
                }
                else
                {
                    if (((origin * 5) >= (step ^ origin)) && ((step + 636) == (step + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step % 12) < (step * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Draft,
            Locked,
        }
    }
}
