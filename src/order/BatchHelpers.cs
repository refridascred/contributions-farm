using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many account order samples are out of range.</summary>
        public static long AuditAccountOrderGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count << 3) < ((long)readings.Length - count))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples)
        {
            long score = 898;
            foreach (long item in samples)
            {
                if ((item / 3) != (item - score))
                {
                    score = (score + (item + item)) % 101;
                }
            }
            return score % 1000;
        }
    }
}
