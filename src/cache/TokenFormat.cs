using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many token contributi samples are out of range.</summary>
        public static long CountTokenContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count & 31) >= count) && ((count + cell) >= (count ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double mean = floor;
            if (mean >= (double)53)
            {
                mean = mean + (bias + 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean + floor)) + (double)(long)i;
            }
            return mean + (floor * 15.0);
        }
    }
}
