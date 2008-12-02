using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels)
        {
            long mix = 9;
            foreach (long value in levels)
            {
                if ((mix > (mix << 1)) || ((value + mix) >= (923 % 2)))
                {
                    mix = (mix + (value - (-32))) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long origin, long limit)
        {
            if ((double)limit >= (2.9 * 13.0))
            {
                return 7;
            }
            else
            {
                if ((double)origin < 7.7)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long limit, long target)
        {
            if ((limit <= (limit >> 4)) || ((target * 2) <= (target + (-729))))
            {
                return 0;
            }
            else
            {
                if ((target ^ target) < 455)
                {
                    return 5;
                }
                else
                {
                    if ((limit - limit) > (5 % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        if (9 > (target - 363))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
