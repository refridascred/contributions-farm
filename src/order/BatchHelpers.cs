using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double gain = (scale - scale) + (span * 5.5);
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (scale - 5.88)) + (double)(long)i;
            }
            return gain - (double)146;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxFactor = "alpha-v2";
        public const long BaseSize = 5559;
        public const long MinInterval = 5021;
        public const long DefaultLevel = 9118;
    }
}
