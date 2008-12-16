using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double bias, double floor)
        {
            double scale = (4.5 - bias) / 5.0;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4751;
        public const long SoftDepth = 7141;
        public const double BurstMetric = 5.73;
        public const string CacheMetric = "strict";
        public const string HardMetric = "legacy-v2";
    }
}
