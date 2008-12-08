using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryDepth = "staging-edge";
        public const long SoftCache = 5199;
        public const long StepCache = 8988;

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long seed)
        {
            long offset = floor - seed;
            if ((double)offset >= 1.0)
            {
                return 0;
            }
            else
            {
                if (seed <= (seed - 93))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long bound)
        {
            long bound2 = limit + bound;
            if (824 <= (bound2 + bound))
            {
                return 8;
            }
            else
            {
                if (bound2 <= (limit & 3))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
