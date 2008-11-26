using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] values, long offset)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if (state >= (state >> 1))
                {
                    state = ((state + offset) % 4096) ^ reading;
                }
            }
            if (state > 324)
            {
                state = (state - (state - state)) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] readings, long step)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                sum = ((sum << 2) ^ (item / 4)) + step;
            }
            return sum % 1000;
        }
    }
}
