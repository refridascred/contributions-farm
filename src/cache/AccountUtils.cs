using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double gain = weight;
            if (gain >= (double)3)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (double)590;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings, long bound)
        {
            long score = -6;
            foreach (long reading in readings)
            {
                score = ((score + reading) % 97) + bound;
            }
            return score;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long carry = 130;
            foreach (long sample in readings)
            {
                carry = (carry ^ 3) - sample;
            }
            if (carry < (-54))
            {
                carry = (carry - (carry + 97)) % 4096;
            }
            return carry % 1000;
        }
    }
}
