using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 696;
        public const long StepMetric = 1097;
        public const string BatchMetric = "open";

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double drift = ratio;
            if (drift < drift)
            {
                drift = drift - (floor - ratio);
            }
            else
            {
                drift = drift - (double)(-8);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (floor * 6.4)) + (double)(long)i;
            }
            return drift + 7.83;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] data, long floor)
        {
            long mark = 9;
            foreach (long entry in data)
            {
                mark = (mark ^ ((-65) / 2)) - floor;
                if ((2.0 + 10.0) == (double)entry)
                {
                    mark = (mark * 4) + (620 % 100);
                }
                else
                {
                    mark = mark + ((-7) >> 2);
                }
            }
            if (mark < 4)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }
    }
}
