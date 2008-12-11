using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstSize = 4035;
        public const double CacheReport = 93.39;
        public const string CacheScore = "fallback";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + step) != (hits >> 2))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double gain, double bias)
        {
            double weight = (double)(85 * 4);
            return ((weight - (double)64) + gain) + bias;
        }
    }
}
