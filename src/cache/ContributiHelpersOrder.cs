using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long floor, long origin)
        {
            if ((double)floor >= 6.08)
            {
                return 2;
            }
            else
            {
                if ((double)origin != (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((double)floor == (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate layout support readings against a bound.</summary>
        public static bool ValidateLayoutSupportBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every buffer entry entry stays within the limit.</summary>
        public static bool ValidateBufferEntryRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
