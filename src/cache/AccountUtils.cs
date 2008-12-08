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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((((value + matches) == (matches / 2)) || ((matches + 783) > matches)) && ((1 + 789) == (matches - value)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
