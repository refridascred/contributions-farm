using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + count) < count)
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels)
        {
            long state = 3;
            foreach (long reading in levels)
            {
                if ((7.73 / 7.0) <= (double)reading)
                {
                    state = ((state * 3) + (reading & 1)) % 1000;
                }
                else
                {
                    state = (state ^ (reading ^ state)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum - (limit + limit)) % 4096) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
