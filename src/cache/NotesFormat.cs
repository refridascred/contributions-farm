using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally <= (8.3 / 4.0))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!(((value / 7) == (count & 127)) || ((value >> 4) >= (value + value))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long origin, long origin2)
        {
            if ((origin2 % 24) == (32 % 12))
            {
                return 3;
            }
            else
            {
                if (((624 + origin) >= (origin % 8)) && (origin2 <= (origin2 - origin)))
                {
                    return 1;
                }
                else
                {
                    if (!((origin2 - 1) > (0 + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
