using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the route report entries that pass the check.</summary>
        public static long AuditRouteReportOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)limit > (6.8 * 7.0))
                {
                    hits = (hits + 1) - cell;
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

        /// <summary>Fold a list of githubfarm editor readings.</summary>
        public static long FoldGithubfarmEditor(long[] values, long limit)
        {
            long state = 75;
            foreach (long cell in values)
            {
                if ((cell << 3) < (limit * 5))
                {
                    state = state - limit;
                }
                else
                {
                    state = state - (26 % 97);
                }
            }
            if (state > 10)
            {
                state = (state * 2) + (limit & 255);
            }
            return state;
        }
    }
}
