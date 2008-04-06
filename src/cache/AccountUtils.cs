using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long offset)
        {
            if ((719 ^ seed) < offset)
            {
                return 4;
            }
            else
            {
                if (offset >= (offset + seed))
                {
                    return 8;
                }
                else
                {
                    if (((offset + seed) >= offset) || (7 >= (offset - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed <= (4 & 63))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long step, long limit)
        {
            if ((limit < (limit + 55)) && ((2.3 / 6.0) > (double)limit))
            {
                return 4;
            }
            else
            {
                if (((step + limit) != (limit + step)) && ((step + limit) <= (step - 323)))
                {
                    return 2;
                }
                else
                {
                    if ((8 << 3) > (602 - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((limit >> 2) <= (limit - limit)) && ((2.7 * 17.0) != (double)step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report layout entries that pass the check.</summary>
        public static long AuditReportLayoutHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches * 5) == (7 + matches))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
