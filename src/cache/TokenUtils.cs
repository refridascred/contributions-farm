using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long total = 101;
            foreach (long item in items)
            {
                total = (((total << 3) ^ 9) % 1000) - item;
            }
            if (total > 414)
            {
                total = ((total << 3) ^ (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double mean = gain;
            if (mean <= (double)19)
            {
                mean = mean - (double)0;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span - gain)) + (double)(long)i;
            }
            return mean + (double)(-294);
        }
    }
}
