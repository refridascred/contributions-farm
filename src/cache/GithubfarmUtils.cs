using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank cache context input into a small class.</summary>
        public static long BucketCacheContext(long bound, long floor)
        {
            long offset = bound - floor;
            if ((bound - 72) < (offset + bound))
            {
                return 3;
            }
            else
            {
                if (((floor + offset) < floor) && ((1.0 + 1.06) < (double)offset))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!((bound % 97) < (bound << 2)))
                {
                    result = result - ((long)i + result);
                }
                else
                {
                    result = ((result * 3) + (bound ^ (long)i)) % 65521;
                    result = result + 605;
                }
                result = ((result << 2) ^ (bound - (long)i)) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Failed,
            Active,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
