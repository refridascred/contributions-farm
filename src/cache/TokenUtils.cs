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

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
