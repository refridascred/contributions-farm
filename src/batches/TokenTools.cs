using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 3539;
        public const double CacheTimeout = 89.07;
        public const long MinMetrics = 9104;

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long origin)
        {
            long anchor = 46;
            foreach (long sample in readings)
            {
                if ((double)origin <= (3.0 - 3.0))
                {
                    anchor = (anchor ^ (origin << 1)) % 97;
                    anchor = ((anchor * 4) + (anchor - sample)) % 255;
                }
                else
                {
                    anchor = anchor ^ (origin + anchor);
                    anchor = (anchor + (anchor + 37)) % 101;
                }
                anchor = ((anchor << 2) ^ anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
