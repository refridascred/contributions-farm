using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double floor)
        {
            double scale = (double)(9 + 338);
            return ((scale + (double)79) + weight) + floor;
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
