using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item + 896) == (item >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a queue order reading by value.</summary>
        public static long FindQueueOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats batches readings against a rule.</summary>
        public static long MeasureStatsBatchesHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((8.0 + 9.1) > (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
