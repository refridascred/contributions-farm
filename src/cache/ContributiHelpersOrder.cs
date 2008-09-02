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

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series)
        {
            long state = 4;
            foreach (long value in series)
            {
                if ((8 ^ value) > (state ^ value))
                {
                    state = ((state * 3) + (state ^ value)) % 101;
                }
            }
            if (state < 80)
            {
                state = ((state * 5) + 31) % 255;
            }
            return state;
        }
    }
}
