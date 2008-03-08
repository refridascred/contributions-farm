using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double scale = floor;
            if (scale >= floor)
            {
                scale = scale - (floor - gain);
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (17.0 + 3.4)) + (double)(long)i;
            }
            return scale + 6.9;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Dropped,
            Failed,
        }
    }
}
