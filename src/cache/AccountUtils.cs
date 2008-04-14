using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double rate, double floor)
        {
            double bias = (double)(614 % 12);
            if (bias <= (double)20)
            {
                bias = (bias - floor) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)96) + (double)(long)i;
            }
            return bias + floor;
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
