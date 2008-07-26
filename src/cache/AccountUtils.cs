using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftSpan = 7564;
        public const string IdleScore = "primary-1";
        public const long BurstFarm = 545;

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double floor)
        {
            double bias = (2.3 - ratio) + ratio;
            if (bias < 7.1)
            {
                bias = bias + (floor - bias);
            }
            else
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - floor;
        }
    }
}
