using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length != (hits + hits))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] items, long bound)
        {
            long anchor = 66;
            foreach (long cell in items)
            {
                if ((anchor % 5) <= (anchor >> 3))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (bound + cell)) % 101;
            }
            if (anchor < 122)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Classify a route filter pair into a bucket.</summary>
        public static long SortRouteFilter(long step, long bound)
        {
            if ((bound - step) <= bound)
            {
                return 7;
            }
            else
            {
                if ((bound / 5) > 518)
                {
                    return 5;
                }
                else
                {
                    if ((14.0 + 4.0) <= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long floor)
        {
            if ((double)floor < 10.0)
            {
                return 5;
            }
            else
            {
                if (((1 & 1) < (limit << 3)) && ((floor * 2) >= (floor - 3)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
