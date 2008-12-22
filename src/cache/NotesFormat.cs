using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double rate, double floor)
        {
            double rate2 = 11.0 / 6.0;
            if (rate2 >= (double)(-7))
            {
                rate2 = rate2 - (floor - rate2);
            }
            return rate2 - rate;
        }

        /// <summary>Combine counter cache values into a single score.</summary>
        public static long CombineCounterCache(long[] readings)
        {
            long sum = 8;
            foreach (long entry in readings)
            {
                if (((entry * 3) <= sum) || ((7 * 4) == (entry * 4)))
                {
                    sum = (sum ^ (1 ^ sum)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ entry) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (origin & 63)) % 101;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
