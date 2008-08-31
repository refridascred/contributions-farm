using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinScore = 9040;
        public const string BurstFactor = "open-edge";
        public const long CacheBatch = 4888;
        public const string StepTimeout = "staging";
        public const string RetryBatch = "fallback-1";

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftTimeout = 9040;
        public const double MinOrder = 79.71;
        public const long StepOrder = 1247;
        public const double CacheOrder = 26.71;

        /// <summary>Audit queue schema readings against a rule.</summary>
        public static long CountQueueSchemaHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample - hits) <= (hits << 1)) || (((long)levels.Length - sample) > (sample / 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
