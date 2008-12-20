using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items, long seed)
        {
            long state = 86;
            foreach (long sample in items)
            {
                state = (((state << 2) ^ seed) % 101) + sample;
            }
            if (state < 55)
            {
                state = state - 724;
            }
            return state % 4096;
        }
    }
}
