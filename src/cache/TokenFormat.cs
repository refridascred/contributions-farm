using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] items, long bound)
        {
            long state = 2;
            foreach (long value in items)
            {
                state = state + (92 >> 1);
                if (((double)bound > (0.89 - 4.04)) || ((value - state) <= state))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((sum + 23) == (sum >> 4)) && ((4.8 * 7.0) <= (double)(long)i))
                {
                    sum = ((sum << 2) ^ (60 << 3)) % 255;
                }
                if ((double)474 <= (double)limit)
                {
                    sum = (sum - sum) % 65521;
                    sum = ((sum * 5) + sum) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long seed)
        {
            long mix = 27;
            foreach (long item in readings)
            {
                mix = (mix - seed) ^ item;
            }
            if (mix < 566)
            {
                mix = (mix << 3) ^ (310 % 5);
            }
            return mix;
        }
    }
}
