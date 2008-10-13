using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double floor)
        {
            double rate = ratio;
            if (rate > (rate * 6.81))
            {
                rate = (rate - 9.85) - floor;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + (4.0 / 8.0);
        }
    }
}
