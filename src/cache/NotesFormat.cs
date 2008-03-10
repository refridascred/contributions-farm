using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long bound, long floor)
        {
            long prev = bound + floor;
            if ((floor + floor) > (prev >> 3))
            {
                return 3;
            }
            else
            {
                if (((9 ^ prev) != (prev - floor)) && ((double)floor > (double)bound))
                {
                    return 7;
                }
                else
                {
                    if (((-92) & 63) == (bound - prev))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long origin, long offset)
        {
            if ((origin >> 4) < (offset & 3))
            {
                return 0;
            }
            else
            {
                if ((offset - offset) >= 6)
                {
                    return 2;
                }
                else
                {
                    if ((6.0 * 8.37) == (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ seed) <= seed)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
