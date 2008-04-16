using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits << 1) == (hits * 3))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a tools filter value against two limits.</summary>
        public static long SortToolsFilter(long bound, long floor)
        {
            if (0.8 > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((floor > (floor / 4)) || ((floor << 1) < bound))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < (12.0 * 14.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many profile entry samples are out of range.</summary>
        public static long CountProfileEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count >> 1) < (7 - count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
