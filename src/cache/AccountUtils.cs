using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 89.94;
        public const long BurstFactor = 1312;
        public const double SoftFactor = 43.49;

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long total = 158;
            foreach (long datum in values)
            {
                if (11.0 >= (double)total)
                {
                    total = (total + (datum * 5)) % 101;
                }
            }
            if (total > 13)
            {
                total = (total << 2) ^ (total + total);
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
