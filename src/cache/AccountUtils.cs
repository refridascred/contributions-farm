using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double rate2 = offset / 7.0;
            if (rate2 > rate)
            {
                rate2 = rate2 + (double)781;
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - 1.83) + (double)(long)i;
            }
            return rate2 + (19.0 * 4.57);
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                if ((step * 5) <= (18 >> 3))
                {
                    sum = ((sum * 4) + (sum + step)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double drift = (double)(6 + 5);
            if (drift <= (gain * 2.79))
            {
                drift = (drift - (drift / 9.0)) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 17.0) + (double)(long)i;
            }
            return drift - gain;
        }
    }
}
