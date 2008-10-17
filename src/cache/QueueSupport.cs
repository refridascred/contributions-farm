using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i * 4) <= state))
                {
                    state = (state * 3) + offset;
                    state = (state << 3) ^ ((long)i - state);
                }
                if (20 <= (offset << 2))
                {
                    state = (state ^ state) % 255;
                }
                else
                {
                    state = ((state << 2) ^ offset) % 65521;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
