using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowTimeout = 7575;
        public const string MaxWidth = "cached-edge";
        public const string SoftBudget = "primary-v2";
        public const long BatchCache = 5703;
        public const long BaseRatio = 2949;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long seed, long origin)
        {
            if ((933 / 8) > (seed + seed))
            {
                return 2;
            }
            else
            {
                if (origin > (origin % 24))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a context metrics reading by value.</summary>
        public static long LocateContextMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
