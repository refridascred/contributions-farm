using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits <= (reading * 4))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long offset)
        {
            if (((floor + offset) != (offset & 3)) || (floor <= (offset & 31)))
            {
                return 8;
            }
            else
            {
                if (!((floor + floor) <= offset))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((((seed * 4) < item) || ((double)4 != (double)item)) && (((matches * 2) >= ((long)items.Length + item)) && (((-515) % 5) >= item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell < (hits - step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
