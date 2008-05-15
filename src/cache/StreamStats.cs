using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((2.7 + 0.3) < (double)floor) && ((reading ^ count) >= (reading + 701)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total - offset)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((6.0 < (double)state) || ((long)i <= (344 * 3)))
                {
                    state = (state ^ (9 / 9)) % 97;
                }
                else
                {
                    state = ((state * 2) + (state + seed)) % 255;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = state + ((long)i2 % 3);
                }
                state = (state ^ ((long)i + state)) % 101;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            New,
            Stale,
            Failed,
            Ready,
        }
    }
}
