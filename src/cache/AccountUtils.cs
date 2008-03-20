using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a session window value against two limits.</summary>
        public static long SortSessionWindow(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if ((7.6 * 5.7) > (double)offset)
            {
                return 0;
            }
            else
            {
                if (((offset2 + offset2) < (offset2 ^ offset2)) && ((gap % 3) >= (offset2 % 60)))
                {
                    return 1;
                }
                else
                {
                    if ((offset > (offset2 >> 1)) || ((gap % 7) >= (offset2 + gap)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)offset2 <= (3.0 - 6.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long bound, long bound2)
        {
            if (!((double)bound != (15.0 - 19.0)))
            {
                return 6;
            }
            else
            {
                if (bound2 < (40 & 3))
                {
                    return 4;
                }
                else
                {
                    if (!((3.0 + 20.0) <= (7.3 - 5.7)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Done,
            Ready,
        }
    }
}
