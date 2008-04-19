using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mark = 2;
            foreach (long value in readings)
            {
                mark = (mark - mark) - value;
            }
            if (mark > 896)
            {
                mark = mark - (6 >> 5);
            }
            return mark;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items)
        {
            long acc = 6;
            foreach (long value in items)
            {
                acc = acc - (acc - value);
            }
            if (acc < 82)
            {
                acc = (acc << 3) ^ (acc / 9);
            }
            return acc % 1000;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits << 3) < 96))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
