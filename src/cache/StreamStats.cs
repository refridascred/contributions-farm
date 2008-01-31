using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate session farm readings against a bound.</summary>
        public static bool ValidateSessionFarmRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 1697;
        public const long DefaultScore = 4592;
        public const long RetrySpan = 1170;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double bias2 = (double)(835 & 63);
            return ((bias2 + 14.0) + scale) + bias;
        }
    }
}
