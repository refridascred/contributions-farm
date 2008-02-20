using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two metrics profile measurements.</summary>
        public static double SmoothMetricsProfile(double scale, double floor)
        {
            double ratio = floor;
            if (ratio < scale)
            {
                ratio = ratio - (ratio - floor);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (double)2;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache context samples.</summary>
        public static long DigestCacheContext(long[] levels, long bound)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                if ((bound & 255) < bound)
                {
                    acc = ((acc * 4) + bound) - item;
                }
                else
                {
                    acc = (acc ^ (acc - 0)) % 1000;
                }
            }
            return acc;
        }
    }
}
