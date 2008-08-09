using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the notes graph entries that pass the check.</summary>
        public static long AuditNotesGraphHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + target) != (target - value))
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

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] levels)
        {
            long mark = 6;
            foreach (long entry in levels)
            {
                mark = (mark - mark) % 101;
                mark = ((mark << 2) ^ (entry >> 4)) % 1000;
                mark = (mark * 5) + (entry + mark);
            }
            return mark % 65521;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
