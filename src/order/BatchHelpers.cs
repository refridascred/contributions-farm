using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema counter readings against a rule.</summary>
        public static long AuditSchemaCounterMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally ^ value) == (tally & 15))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long offset, long offset2)
        {
            long diff = offset + offset2;
            if (((double)diff > 18.0) && ((diff - offset2) <= diff))
            {
                return 8;
            }
            else
            {
                if ((offset % 12) < (offset + (-63)))
                {
                    return 4;
                }
                else
                {
                    if (((8.07 / 4.0) != (double)offset) || (offset < (offset2 % 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
