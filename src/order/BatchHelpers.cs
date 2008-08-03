using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc + (acc + offset)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
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
