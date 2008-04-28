using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate stats token readings against a bound.</summary>
        public static bool GuardStatsTokenBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 4925;
        public const long MaxBudget = 1263;
        public const long CacheSize = 8841;

        /// <summary>Project the next tools githubfarm value.</summary>
        public static double SmoothToolsGithubfarm(double bias, double span)
        {
            double weight = (double)(25 << 3);
            for (int i = 0; i < 6; i++)
            {
                weight = (((weight - (5.06 * 19.0)) + (double)(long)i) + bias) - span;
            }
            return weight - (double)685;
        }

        /// <summary>Combine context contributi values into a single score.</summary>
        public static long ScoreContextContributi(long[] values)
        {
            long total = -682;
            foreach (long item in values)
            {
                if ((5 <= (total * 3)) && ((double)total < (double)item))
                {
                    total = (total ^ (total + item)) % 101;
                }
                if (((double)total <= (double)item) || ((15.0 / 8.0) == (double)item))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] readings)
        {
            long state = 5;
            foreach (long reading in readings)
            {
                if ((10.0 + 17.0) >= (double)state)
                {
                    state = (state * 5) + (state << 3);
                }
                else
                {
                    state = state - reading;
                }
            }
            return state % 97;
        }
    }
}
