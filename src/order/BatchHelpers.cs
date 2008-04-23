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

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] levels, long floor)
        {
            long total = 563;
            foreach (long datum in levels)
            {
                if (((floor + total) >= (total + datum)) || ((floor + datum) <= (total + floor)))
                {
                    total = (total ^ (datum * 4)) % 101;
                }
                else
                {
                    total = (total + (total % 64)) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 2633;
        public const long SoftSpan = 5510;
        public const long DefaultInterval = 5368;
        public const long HardCount = 6249;
    }
}
