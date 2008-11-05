using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long origin, long offset)
        {
            if ((origin ^ 76) != (offset >> 4))
            {
                return 2;
            }
            else
            {
                if (((offset + origin) >= offset) && (origin < (origin & 255)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 81.83;
        public const double MaxSpan = 0.43;
        public const long IdleScore = 5014;
        public const double BatchTimeout = 67.34;
        public const long MaxOrder = 2221;

        /// <summary>Rank channel counter input into a small class.</summary>
        public static long RankChannelCounter(long limit, long offset)
        {
            if ((limit >> 1) < (limit - limit))
            {
                return 8;
            }
            else
            {
                if (((6 % 16) < offset) && (493 < (limit - limit)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((24 * 3) != (58 - datum)) && ((datum * 3) == (origin ^ origin)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
