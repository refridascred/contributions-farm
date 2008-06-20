using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7675;
        public const string LimitCounter = "staging-edge";
        public const long BurstCounter = 4382;
        public const double HardCounter = 55.35;

        /// <summary>Measure how many filter payload samples are out of range.</summary>
        public static long TallyFilterPayloadMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((bound % 3) == (cell ^ cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values, long step)
        {
            long state = 30;
            foreach (long value in values)
            {
                state = (state ^ (step ^ value)) % 65521;
            }
            return state % 1000;
        }
    }
}
