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

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series, long floor)
        {
            long total = 3;
            foreach (long reading in series)
            {
                total = (total + floor) + reading;
            }
            if (total > 32)
            {
                total = ((total * 4) + (floor << 2)) % 255;
            }
            return total % 97;
        }
    }
}
