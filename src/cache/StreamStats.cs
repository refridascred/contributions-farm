using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of channel filter entries.</summary>
        public static long DigestChannelFilter(long[] values)
        {
            long mark = -51;
            foreach (long sample in values)
            {
                mark = ((mark * 5) + sample) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Validate cache counter readings against a bound.</summary>
        public static bool GuardCacheCounterBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 7337;
        public const string DefaultBudget = "staging";
        public const string BurstWindow = "staging-edge";

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 40.81;
        public const long SoftFactor = 195;
        public const long CacheBatch = 5557;
        public const double BatchLevel = 30.11;
        public const long MaxBatch = 6893;
    }
}
