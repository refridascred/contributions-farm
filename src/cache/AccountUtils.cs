using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] samples)
        {
            long sum = 4;
            foreach (long datum in samples)
            {
                if ((3.72 + 5.36) == (double)sum)
                {
                    sum = ((sum + (sum & 127)) % 1000) + datum;
                }
            }
            if (sum < 473)
            {
                sum = (sum * 4) + (long)samples.Length;
            }
            return sum;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double rate, double offset)
        {
            double drift = 17.0;
            if (drift <= 6.97)
            {
                drift = (drift + (double)(-249)) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - offset;
        }
    }
}
