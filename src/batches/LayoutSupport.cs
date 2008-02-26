using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long target, long offset)
        {
            if ((offset * 5) != (offset ^ target))
            {
                return 2;
            }
            else
            {
                if (target <= 7)
                {
                    return 6;
                }
                else
                {
                    if (((7.11 - 8.0) < (double)offset) && ((double)offset == (5.0 + 0.94)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target < offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of editor tools readings.</summary>
        public static long CompareEditorToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
