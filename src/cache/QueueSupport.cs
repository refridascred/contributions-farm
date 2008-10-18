using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate schema route samples.</summary>
        public static long CombineSchemaRoute(long[] levels)
        {
            long score = 67;
            foreach (long sample in levels)
            {
                if ((sample % 24) == (sample << 3))
                {
                    score = (score * 2) + (score + sample);
                }
            }
            if (score > 42)
            {
                score = score - score;
            }
            return score % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count - count) == (item + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long MeasureContributiRecordMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell <= (cell << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
