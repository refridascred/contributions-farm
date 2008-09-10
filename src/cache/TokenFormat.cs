using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 67.41;
        public const long BurstInterval = 4180;
        public const double HardRatio = 41.7;
        public const string CacheTimeout = "alpha";

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] samples)
        {
            long mark = 86;
            foreach (long sample in samples)
            {
                mark = (mark + mark) % 97;
                if ((mark << 2) > (104 ^ mark))
                {
                    mark = ((mark * 4) + (399 + 442)) % 255;
                }
                mark = ((mark * 3) + sample) % 4096;
            }
            return mark;
        }
    }
}
