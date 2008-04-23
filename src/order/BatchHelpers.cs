using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed >> 4) <= (state & 15))
                {
                    state = (state + (seed >> 1)) % 97;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 3619;
        public const long SoftLevel = 5683;
        public const long BaseScore = 7548;
        public const long StepAlready = 1527;
        public const long RetryBudget = 9598;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 2633;
        public const long SoftSpan = 5510;
        public const long DefaultInterval = 5368;
        public const long HardCount = 6249;
    }
}
