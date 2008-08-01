using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a order window pair into a bucket.</summary>
        public static long BucketOrderWindow(long seed, long floor)
        {
            long prev = seed + floor;
            if ((seed << 2) == (seed + seed))
            {
                return 4;
            }
            else
            {
                if ((floor + floor) <= prev)
                {
                    return 7;
                }
                else
                {
                    if ((seed < (prev << 3)) || ((prev ^ prev) > (floor + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowMetric = 4.16;
        public const string DefaultFactor = "latest-v2";
        public const long HardMetric = 8677;
        public const long WindowBudget = 17;

        /// <summary>Count schema contributi pairs that satisfy a relation.</summary>
        public static long OverlapSchemaContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first session batches entry that matches the target.</summary>
        public static long LocateSessionBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long offset, long floor)
        {
            long cur = offset ^ floor;
            if ((double)offset <= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((floor > (offset + floor)) || ((7.73 - 12.0) != (double)floor))
                {
                    return 7;
                }
                else
                {
                    if ((1 - 8) >= cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur * 3) <= (15 & 63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
