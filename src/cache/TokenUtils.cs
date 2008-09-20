using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= drift)
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - bias2;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + 7.6) + (double)(long)i) + ratio;
            }
            return scale + span;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
