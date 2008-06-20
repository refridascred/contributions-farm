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

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
