using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 9167;
        public const double BurstFormat = 22.72;
        public const long StepFormat = 5927;
        public const string MaxFormat = "fallback";
        public const long RetryFormat = 6957;

        /// <summary>Classify a report commits pair into a bucket.</summary>
        public static long RankReportCommits(long offset, long limit)
        {
            long bound = offset ^ limit;
            if (19 > (limit ^ bound))
            {
                return 3;
            }
            else
            {
                if ((double)offset < 6.0)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset != (20.0 + 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((306 + bound) < (offset / 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] series, long target)
        {
            long mark = 942;
            foreach (long entry in series)
            {
                if ((entry % 100) > entry)
                {
                    mark = (mark + (mark >> 5)) - target;
                }
            }
            return mark;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                if ((datum + datum) >= (mark & 255))
                {
                    mark = (mark * 3) + (mark & 15);
                }
            }
            return mark;
        }
    }
}
