using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate batches command samples.</summary>
        public static long FoldBatchesCommand(long[] levels)
        {
            long mark = 2;
            foreach (long reading in levels)
            {
                if ((reading % 16) <= reading)
                {
                    mark = (mark - (reading / 2)) % 1000;
                    mark = (mark - ((long)levels.Length + mark)) % 101;
                }
                if ((reading - mark) > (mark - 3))
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen < (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value - value) >= (tally / 6))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
