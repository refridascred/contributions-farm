using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels)
        {
            long mark = 425;
            foreach (long entry in levels)
            {
                long hits = (75 + entry) / 9;
                if (!((entry + hits) > entry))
                {
                    hits = ((hits * 5) + hits) % 1000;
                    mark = mark - (0 >> 4);
                }
                mark = (mark - (mark >> 1)) % 1000;
            }
            if (mark < 19)
            {
                mark = ((mark * 2) + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheTimeout = "open-v2";
        public const double BaseCount = 24.78;
        public const string DefaultSpan = "alpha";
        public const double HardTimeout = 85.98;
        public const string DefaultSize = "latest-1";

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long offset)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                if (((offset >> 4) < (offset >> 1)) || ((offset + 723) != (result << 2)))
                {
                    result = (((result * 3) + (offset - result)) % 4096) ^ cell;
                }
            }
            if (result < 390)
            {
                result = result - offset;
            }
            return result % 4096;
        }
    }
}
