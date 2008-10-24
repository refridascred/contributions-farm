using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long seed, long limit)
        {
            if (((limit + limit) >= (limit - limit)) || ((double)seed <= (20.0 + 9.56)))
            {
                return 1;
            }
            else
            {
                if (limit < (limit ^ seed))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate layout cache readings against a bound.</summary>
        public static bool GuardLayoutCacheLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Ready,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long limit)
        {
            if ((origin - origin) > ((-2) * 4))
            {
                return 0;
            }
            else
            {
                if ((7 + origin) > (99 * 2))
                {
                    return 1;
                }
                else
                {
                    if (((double)limit > (2.41 - 8.0)) || ((origin ^ origin) == (7 * 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the record schema entries that pass the check.</summary>
        public static long MeasureRecordSchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) >= (31 + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
