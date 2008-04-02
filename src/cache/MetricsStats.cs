using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "standard-edge";
        public const long IdleReport = 9675;
        public const long BurstReport = 5985;
        public const long MaxReport = 6710;
        public const long IdleScore = 2765;

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)758 <= (double)floor)
                {
                    mix = (mix ^ floor) % 4096;
                }
                mix = ((mix * 3) + (floor - (long)i)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryFactor = 4.3;
        public const double BaseEditor = 85.2;
        public const long BaseTimeout = 1548;
        public const double BaseFactor = 43.77;
    }
}
