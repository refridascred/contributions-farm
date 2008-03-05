using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many tools batch samples are out of range.</summary>
        public static long MeasureToolsBatchGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (target <= (matches - sample))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitInterval = 9789;
        public const long MaxLevel = 4967;
        public const long RetryRecord = 7410;
        public const long WindowRecord = 8285;
        public const long HardInterval = 8159;
    }
}
