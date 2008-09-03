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

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long offset, long origin)
        {
            if (((8 ^ offset) >= origin) || ((791 ^ offset) > (origin - 921)))
            {
                return 0;
            }
            else
            {
                if (!(origin > (origin + (-842))))
                {
                    return 2;
                }
                else
                {
                    if ((49 - 7) > (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3.3 / 3.0) >= (double)origin) || ((origin + 5) <= (943 << 2)))
                        {
                            return 6;
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
}
