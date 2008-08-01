using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchBudget = 285;
        public const long MinBatch = 5154;
        public const long IdleDepth = 8325;
        public const long RetryBatch = 1479;
        public const string WindowBatch = "stable-v2";

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits + 8) >= (5 / 9))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

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

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
