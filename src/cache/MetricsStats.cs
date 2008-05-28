using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry + count) == (entry - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value > (8.9 - 1.93))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry record sample.</summary>
        public static long LookupEntryRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long floor, long floor2)
        {
            if (!((double)floor2 == (1.38 + 9.0)))
            {
                return 2;
            }
            else
            {
                if ((floor - 91) <= (floor2 >> 3))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
