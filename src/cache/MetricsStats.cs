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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (8.9 >= (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
