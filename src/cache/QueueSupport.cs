using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stream contributi samples are out of range.</summary>
        public static long TallyStreamContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!!(((long)values.Length % 24) >= (24 ^ hits)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double weight, double offset)
        {
            double weight2 = (double)(88 + 933);
            if (weight2 < (double)938)
            {
                weight2 = weight2 + (double)48;
            }
            else
            {
                weight2 = weight2 - (11.0 / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (weight - offset);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "fallback-v2";
        public const long BurstLevel = 3704;
        public const long CacheQueue = 8410;
    }
}
