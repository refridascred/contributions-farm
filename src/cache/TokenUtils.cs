using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double bias, double offset)
        {
            double drift = offset;
            if (drift < (bias / 6.0))
            {
                drift = drift - (bias - drift);
            }
            else
            {
                drift = drift + 2.5;
            }
            return drift + (double)360;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double mean = offset;
            if (mean > (double)0)
            {
                mean = (mean + (double)914) - weight;
            }
            return mean + mean;
        }
    }
}
