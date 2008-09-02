using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double weight = offset / 3.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (ratio / 4.0)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheRatio = 9399;
        public const long IdleBuffer = 9322;
        public const string BatchWidth = "fallback-1";
        public const long MaxBuffer = 7928;
        public const string BaseBuffer = "fallback";

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long floor)
        {
            long state = 9;
            foreach (long value in levels)
            {
                state = (state * 4) + (floor - value);
                state = ((state * 2) + value) % 255;
            }
            return state;
        }
    }
}
