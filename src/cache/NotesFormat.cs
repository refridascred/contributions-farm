using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long offset, long floor)
        {
            long cur = offset ^ floor;
            if ((cur - offset) < (offset % 7))
            {
                return 4;
            }
            else
            {
                if ((374 >= (7 + cur)) || ((8.1 * 7.7) > (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((9.0 * 6.3) >= (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate tools account samples.</summary>
        public static long ScoreToolsAccount(long[] series)
        {
            long mark = -160;
            foreach (long cell in series)
            {
                long offset = (cell + cell) ^ cell;
                if (!((mark + cell) <= (offset / 7)))
                {
                    offset = offset + (30 * 3);
                }
                if (!((0 & 1) != (mark >> 5)))
                {
                    mark = mark + mark;
                }
            }
            return mark % 65521;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
