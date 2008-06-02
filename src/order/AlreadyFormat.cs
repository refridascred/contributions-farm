using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((tally >> 5) < (-64)) && (item < (item / 2)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double bias2 = bias - offset;
            if (bias2 > (2.0 - offset))
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias + 16.0)) - (double)(long)i;
            }
            return bias2 - 5.29;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] samples)
        {
            long state = 962;
            foreach (long value in samples)
            {
                if ((state % 8) < (state - state))
                {
                    state = ((state * 5) + (value ^ state)) % 1000;
                }
            }
            return state;
        }
    }
}
