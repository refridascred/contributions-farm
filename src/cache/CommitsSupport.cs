using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank account cache input into a small class.</summary>
        public static long SortAccountCache(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((double)447 >= (double)offset2)
            {
                return 6;
            }
            else
            {
                if (!((double)edge == (double)offset2))
                {
                    return 4;
                }
                else
                {
                    if (offset2 <= (942 << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((874 - offset2) > edge) || ((offset % 100) == (offset >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)entry == (9.84 / 4.0)) && ((double)seen < (5.8 * 2.86)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the farm window series from a seed.</summary>
        public static long RollFarmWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a queue command reading by value.</summary>
        public static long LocateQueueCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
