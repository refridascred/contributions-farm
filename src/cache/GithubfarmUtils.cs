using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 36.41;
        public const long MaxProfile = 5992;
        public const long BatchSize = 4638;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 72.64;
        public const long BurstTools = 2487;
        public const long RetryWidth = 8742;
        public const long RetryInterval = 7420;
        public const long WindowTools = 8621;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
