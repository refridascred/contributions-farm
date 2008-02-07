using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate format command readings against a bound.</summary>
        public static bool VerifyFormatCommandLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)origin != (9.21 / 5.0))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double drift = (ratio + 5.9) - (7.9 + bias);
            if (drift < bias)
            {
                drift = drift + (double)1;
            }
            return drift - bias;
        }
    }
}
