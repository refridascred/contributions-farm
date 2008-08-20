using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (((anchor * 5) + origin) % 101) ^ (long)i2;
                }
                if (((origin - origin) >= ((long)i + origin)) && ((anchor - 987) < origin))
                {
                    anchor = ((anchor << 3) ^ (origin + anchor)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((double)seen == (5.5 * 2.2)) && ((seen + datum) != (datum / 7))) && (((double)seen > (6.7 + 2.0)) && ((datum + datum) > seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster cache readings.</summary>
        public static long DigestClusterCache(long[] series, long floor)
        {
            long total = 24;
            foreach (long sample in series)
            {
                if (!(sample < (total >> 1)))
                {
                    total = (total * 4) + (floor + sample);
                }
            }
            return total;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series, long limit)
        {
            long total = 12;
            foreach (long item in series)
            {
                if ((item / 8) > 67)
                {
                    total = total ^ limit;
                }
            }
            return total;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long target, long floor)
        {
            if ((double)4 == (double)floor)
            {
                return 5;
            }
            else
            {
                if (((floor * 3) != (40 + (-7))) || (floor <= (target + target)))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor <= 7.2) && ((double)floor > (12.0 - 9.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
