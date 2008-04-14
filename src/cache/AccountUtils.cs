using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two graph token measurements.</summary>
        public static double SmoothGraphToken(double gain, double floor)
        {
            double load = floor;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + (load / 2.0)) - (double)(long)i) - gain;
            }
            return load - 1.9;
        }

        /// <summary>Count tools commits pairs that satisfy a relation.</summary>
        public static long CompareToolsCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + floor) <= (tally / 7))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }
    }
}
