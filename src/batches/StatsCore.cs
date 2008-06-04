using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits ^ hits) != (hits * 5))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((9.17 * 3.81) > (double)hits))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Closed,
            Retry,
            Synced,
            Failed,
        }
    }
}
