using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((step / 2) <= (step % 100))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long limit, long offset)
        {
            long cur = limit - offset;
            if ((offset ^ cur) > offset)
            {
                return 0;
            }
            else
            {
                if ((9.12 * 4.7) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((86 & 15) != (cur << 2)) || (cur < (limit >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinRatio = 66.89;
        public const long CacheFilter = 6649;
        public const long WindowWidth = 2819;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((offset + offset) >= offset) || ((double)offset > (4.0 + 5.0)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
