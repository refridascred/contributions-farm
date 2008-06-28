using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((5.3 + 6.62) <= (double)limit))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((floor * 4) == (10 + matches)) || ((cell >= (floor + matches)) && (floor > (floor + matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Pending,
            Queued,
            New,
            Stale,
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double bias)
        {
            double mean = rate;
            if (mean >= rate)
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - rate) + (double)(long)i;
            }
            return mean - bias;
        }
    }
}
