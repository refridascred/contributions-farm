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

        /// <summary>Roll a cache schema counter forward.</summary>
        public static long StepCacheSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = (state - (2 + state)) % 65521;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinCount = "legacy-edge";
        public const long LimitAccount = 6731;
        public const long RetryAccount = 2711;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
