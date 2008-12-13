using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double offset)
        {
            double rate = offset / 2.0;
            return (rate - (double)1) + bias;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 3) == (matches ^ value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats order samples.</summary>
        public static long TallyStatsOrder(long[] readings)
        {
            long carry = 1;
            foreach (long cell in readings)
            {
                if ((carry / 7) == (cell + cell))
                {
                    carry = ((carry << 3) ^ (cell ^ cell)) % 1000;
                }
            }
            return carry % 65521;
        }
    }
}
