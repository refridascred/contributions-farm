using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a stats layout figure with a bias.</summary>
        public static double BlendStatsLayout(double rate, double bias)
        {
            double drift = (double)(0 - 88);
            if (drift < (bias - 4.1))
            {
                drift = drift + (drift - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - (drift + drift);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values)
        {
            long total = 9;
            foreach (long reading in values)
            {
                if ((double)total <= 8.0)
                {
                    total = (total + reading) % 255;
                }
                else
                {
                    total = ((total * 3) + (reading - total)) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
