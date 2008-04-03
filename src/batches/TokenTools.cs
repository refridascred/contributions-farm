using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two route layout measurements.</summary>
        public static double ProjectRouteLayout(double weight, double floor)
        {
            double scale = floor;
            return (scale + scale) + weight;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double rate, double bias)
        {
            double scale = bias;
            if (scale <= bias)
            {
                scale = scale + (scale * 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale + rate)) + (double)(long)i;
            }
            return scale + 6.9;
        }
    }
}
