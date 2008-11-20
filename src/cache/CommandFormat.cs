using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next commits batches value from a seed.</summary>
        public static long SeriesCommitsBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((((long)i - floor) >= ((long)i + state)) || ((2 & 31) != (long)i)))
                {
                    state = (state - (state % 16)) % 97;
                }
                if (floor >= (891 - state))
                {
                    state = ((state * 5) + floor) % 65521;
                    state = ((state << 3) ^ (state ^ floor)) % 4096;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowLevel = 5370;
        public const long LimitCounter = 2883;
        public const long SoftCounter = 6206;
        public const string MinFactor = "local-v2";

        /// <summary>Count the tools cache entries that pass the check.</summary>
        public static long MeasureToolsCacheHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((13 - count) < (count & 1)) && (((count >> 2) != (21 - count)) && ((4.15 - 0.58) > (double)(long)items.Length)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Pending,
            Dropped,
        }
    }
}
