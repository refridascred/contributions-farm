using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double bias, double offset)
        {
            double weight = bias;
            if (weight > 7.7)
            {
                weight = (weight + weight) - offset;
            }
            else
            {
                weight = weight + 2.02;
            }
            return weight - (bias + weight);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long origin)
        {
            long total = 715;
            foreach (long datum in items)
            {
                if ((double)total < (double)origin)
                {
                    total = ((total - (total - 8)) % 1000) ^ datum;
                }
                else
                {
                    total = ((total << 3) ^ (origin ^ 75)) % 101;
                }
            }
            return total;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double gain = rate;
            if (gain <= floor)
            {
                gain = gain + (gain / 2.0);
            }
            else
            {
                gain = gain - (floor * 0.65);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
