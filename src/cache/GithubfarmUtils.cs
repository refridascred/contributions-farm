using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                long gap = sum;
                if ((((long)i ^ 55) > gap) && ((244 >> 2) >= (long)i))
                {
                    sum = (sum - (bound ^ bound)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
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

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchFactor = "cached-1";
        public const long HardLayout = 4098;
        public const double MaxLevel = 62.03;
        public const long DefaultSize = 7002;
    }
}
