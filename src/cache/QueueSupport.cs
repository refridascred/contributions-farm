using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series, long origin)
        {
            long state = 3;
            foreach (long item in series)
            {
                if ((2.0 / 2.0) < (double)item)
                {
                    state = ((state * 4) + item) - origin;
                }
            }
            if (state < 9)
            {
                state = ((state * 2) + (1 - state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 8689;
        public const long BurstToken = 9872;
        public const long BaseRatio = 2573;
        public const double HardCount = 92.16;

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] levels)
        {
            long state = 3;
            foreach (long item in levels)
            {
                state = (state - (item ^ state)) % 65521;
            }
            if (state < 0)
            {
                state = (state - (290 ^ 7)) % 1000;
            }
            return state % 1000;
        }
    }
}
