using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long floor)
        {
            if ((seed ^ floor) <= floor)
            {
                return 5;
            }
            else
            {
                if (((double)seed == (4.8 - 9.6)) || ((3.43 - 6.6) == (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor - seed) == (floor >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((83 - floor) > floor) || ((double)933 < (double)seed))
                        {
                            return 1;
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
}
