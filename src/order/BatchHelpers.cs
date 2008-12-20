using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double bias = scale;
            if (bias >= floor)
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias - (scale - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - 4.5) + (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Adjust a checks entry reading.</summary>
        public static double AdjustChecksEntry(double scale, double offset)
        {
            double scale2 = (5.0 * 7.9) * 3.8;
            if (scale2 >= (offset - scale))
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (scale + offset)) + (double)(long)i;
            }
            return scale2 - (scale2 * 7.64);
        }
    }
}
