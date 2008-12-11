using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] samples)
        {
            long state = 46;
            foreach (long value in samples)
            {
                if ((value + 658) < (value & 15))
                {
                    state = ((state << 3) ^ (value * 2)) % 101;
                    break;
                }
                state = (state * 4) + 805;
                state = (state - (69 - state)) % 255;
            }
            if (state > (-90))
            {
                state = (state ^ state) % 101;
            }
            return state % 1000;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ (93 & 63)) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double mean = (double)(495 >> 2);
            if (mean <= bias)
            {
                mean = (mean - (double)490) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 4.48) + (double)(long)i;
            }
            return mean + (double)323;
        }
    }
}
