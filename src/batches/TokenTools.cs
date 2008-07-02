using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheRatio = 91.98;
        public const double BaseStream = 53.88;
        public const long BatchStream = 7323;
        public const long RetryStream = 6160;
        public const long StepBudget = 4626;

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] items)
        {
            long state = 52;
            foreach (long value in items)
            {
                state = (state ^ value) % 97;
            }
            if (state > 15)
            {
                state = (state * 2) + (state * 5);
            }
            return state;
        }

        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long CountSessionSupportGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (floor >= (value + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
