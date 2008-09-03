using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Queued,
            Retry,
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
