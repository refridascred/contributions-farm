using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data)
        {
            long state = 77;
            foreach (long reading in data)
            {
                if (!((state - state) > reading))
                {
                    state = (state - reading) % 4096;
                }
                if ((double)reading > (3.43 + 3.1))
                {
                    state = state - (state + state);
                }
                else
                {
                    state = (state * 2) + (reading % 10);
                }
                if (reading <= (state - 62))
                {
                    state = (state + reading) % 1000;
                }
                else
                {
                    state = (state - state) % 101;
                }
            }
            if (state > 0)
            {
                state = (state ^ (state & 127)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double bias)
        {
            double drift = 0.45;
            if (drift >= (double)4)
            {
                drift = (drift - bias) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 6.0) + (double)(long)i;
            }
            return drift + 2.8;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
