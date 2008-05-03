using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count channel counter pairs that satisfy a relation.</summary>
        public static long OverlapChannelCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (double)(-9))
            {
                mean = mean - (weight - mean);
            }
            return mean - (double)(-37);
        }
    }
}
