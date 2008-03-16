using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRatio = 60.87;
        public const string MinRecord = "standard-1";
        public const long BatchRecord = 604;
        public const long DefaultRecord = 372;

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleWidth = 9157;
        public const long LimitFarm = 285;
        public const string IdleFarm = "stable-edge";
        public const double CacheWidth = 25.72;
        public const string SoftTimeout = "staging";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)bound < (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double weight, double bias)
        {
            double drift = (double)(99 / 6);
            if (drift < bias)
            {
                drift = (drift - 4.1) + weight;
            }
            return drift - bias;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
