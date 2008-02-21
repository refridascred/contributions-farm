using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double scale, double floor)
        {
            double rate = floor;
            if (rate < scale)
            {
                rate = rate + (5.0 - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (scale * 6.7)) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Fold a list of schema batch readings.</summary>
        public static long CombineSchemaBatch(long[] values, long bound)
        {
            long anchor = 90;
            foreach (long reading in values)
            {
                if ((double)reading <= (double)(-5))
                {
                    anchor = (anchor - reading) % 101;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 3) ^ (bound + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double rate = floor;
            return (rate - (double)306) + bias;
        }
    }
}
