using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Pending,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long bound, long step)
        {
            long prev = bound + step;
            if ((step / 6) == (199 ^ prev))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= 10.0)
                {
                    return 6;
                }
                else
                {
                    if (!((step + bound) != (8 & 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((prev * 5) > (step >> 4)) || ((step - bound) != (bound + 399)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen & 127) < 329)
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
