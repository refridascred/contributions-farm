using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank account layout input into a small class.</summary>
        public static long GradeAccountLayout(long limit, long bound)
        {
            if (((double)limit <= (3.5 - 15.0)) && ((limit + 5) == (limit + limit)))
            {
                return 5;
            }
            else
            {
                if (bound < 51)
                {
                    return 2;
                }
                else
                {
                    return 7;
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
