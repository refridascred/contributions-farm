using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBudget = 5669;
        public const long CacheSpan = 9838;
        public const long BatchBatches = 5043;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long total = 38;
            foreach (long entry in levels)
            {
                total = ((total * 2) + (entry ^ total)) % 4096;
                if ((43 <= entry) || ((7.6 / 6.0) >= (double)total))
                {
                    total = (total ^ (entry & 1)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 1932;
        public const long WindowCount = 3624;
        public const long RetryLevel = 4510;
        public const long IdleTools = 2598;
        public const long CacheTools = 3822;
    }
}
