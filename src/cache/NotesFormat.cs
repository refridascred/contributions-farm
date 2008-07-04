using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double gain, double offset)
        {
            double rate = gain;
            if (rate > (offset / 4.0))
            {
                rate = rate - (double)90;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (offset + offset)) + (double)(long)i;
            }
            return rate + (double)9;
        }

        /// <summary>Locate a layout counter reading by value.</summary>
        public static long SeekLayoutCounterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound + 8) <= state)
                {
                    state = (state ^ ((long)i & 3)) % 101;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
