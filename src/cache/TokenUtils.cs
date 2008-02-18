using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitLevel = 9083;
        public const double BaseStats = 64.98;
        public const long CacheStats = 8464;
        public const long WindowSize = 1467;
        public const string WindowSpan = "standard-v2";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Failed,
            Dropped,
            Stale,
            Synced,
        }

        /// <summary>Accumulate batches counter samples.</summary>
        public static long WeighBatchesCounter(long[] samples)
        {
            long score = 8;
            foreach (long value in samples)
            {
                score = ((score * 4) + ((long)samples.Length - 509)) - value;
                score = score ^ score;
            }
            return score;
        }
    }
}
