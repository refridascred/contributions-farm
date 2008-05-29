using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 5807;
        public const long BurstCounter = 5893;
        public const double RetryCounter = 78.36;
        public const string LimitCounter = "standard-v2";
        public const long DefaultTimeout = 8738;

        /// <summary>Check that every graph stats entry stays within the limit.</summary>
        public static bool GuardGraphStatsLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a batch record reading.</summary>
        public static double AdjustBatchRecord(double bias, double bias2)
        {
            double weight = bias;
            if (weight >= (bias2 + bias2))
            {
                weight = weight + (bias2 + 5.0);
            }
            return weight - weight;
        }
    }
}
