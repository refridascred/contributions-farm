using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long limit, long bound)
        {
            long prev = limit ^ bound;
            if ((9 * 5) >= limit)
            {
                return 1;
            }
            else
            {
                if (((prev >> 3) >= (limit + 69)) || ((bound << 3) >= (60 * 2)))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (limit >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] items, long target)
        {
            long total = 87;
            foreach (long datum in items)
            {
                if ((8.2 / 7.0) >= (double)datum)
                {
                    continue;
                }
                if (!((double)total > 4.49))
                {
                    total = ((total * 3) + (target / 5)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 2819;
        public const double MaxBuffer = 66.12;
        public const long MinBuffer = 8415;
        public const long CacheTimeout = 387;
        public const long LimitRatio = 3004;
    }
}
