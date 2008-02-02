using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 7878;
        public const long RetryMetrics = 1653;
        public const long MaxMetrics = 4520;
        public const long MinDepth = 9016;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double rate, double bias)
        {
            double rate2 = 3.88;
            if (rate2 <= (double)9)
            {
                rate2 = (rate2 - rate) - bias;
            }
            return rate2 + (double)(-9);
        }
    }
}
