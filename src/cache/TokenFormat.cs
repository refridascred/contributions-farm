using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double ratio = (double)(835 % 7);
            if (ratio < (double)243)
            {
                ratio = (ratio + rate) + span;
            }
            return ratio + (double)8;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - hits) >= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double scale = bias;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + bias) - (double)(long)i) + bias2;
            }
            return scale + scale;
        }
    }
}
