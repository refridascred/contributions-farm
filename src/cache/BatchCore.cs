using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long origin, long limit)
        {
            if ((1.33 / 4.0) != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((5.0 * 8.0) >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (limit <= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 3905;
        public const long CacheLayout = 3346;
        public const double BaseTimeout = 4.19;

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5360;
        public const long LimitEntry = 5450;
        public const long BatchEntry = 7868;
        public const long RetryBudget = 7257;
    }
}
