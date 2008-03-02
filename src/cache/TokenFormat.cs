using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a layout entry pair into a bucket.</summary>
        public static long ClassifyLayoutEntry(long origin, long seed)
        {
            if (((seed / 5) < (-7)) && (origin < (857 + seed)))
            {
                return 5;
            }
            else
            {
                if (seed <= (seed + origin))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
