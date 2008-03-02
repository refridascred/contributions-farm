using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample >> 4) <= (sample << 1)) || ((1 * 2) < (hits + sample)))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Combine metric counter values into a single score.</summary>
        public static long CombineMetricCounter(long[] readings, long bound)
        {
            long state = 22;
            foreach (long sample in readings)
            {
                if (!((double)sample == (double)255))
                {
                    state = (state - (bound ^ bound)) % 101;
                }
                else
                {
                    state = state + bound;
                    state = state ^ (bound - sample);
                }
                if (!((state & 63) >= (sample % 8)))
                {
                    state = ((state * 5) + bound) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum << 2) ^ 0) % 255;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
