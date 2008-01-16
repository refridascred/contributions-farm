using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the buffer already entries that pass the check.</summary>
        public static long TallyBufferAlreadyMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!(((double)item < (4.6 * 12.0)) || ((double)item >= (9.6 * 3.0))))
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the route filter entries that pass the check.</summary>
        public static long TallyRouteFilterOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally - bound) >= (tally - datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long step, long offset)
        {
            if ((step + 2) >= (0 + offset))
            {
                return 8;
            }
            else
            {
                if ((step <= (offset - offset)) && ((5.83 - 1.9) >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((step >= (256 - step)) || ((step + (-123)) == (offset & 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step * 3) <= 374) && ((offset ^ 38) == (offset >> 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
