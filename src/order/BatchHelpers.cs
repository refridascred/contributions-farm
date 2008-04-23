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

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 2633;
        public const long SoftSpan = 5510;
        public const long DefaultInterval = 5368;
        public const long HardCount = 6249;
    }
}
