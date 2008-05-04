using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a farm cache value against two limits.</summary>
        public static long SortFarmCache(long offset, long floor)
        {
            if ((619 ^ offset) == ((-28) << 1))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) > offset)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Draft,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long offset)
        {
            long delta = floor ^ offset;
            if ((6.0 - 5.6) > (double)delta)
            {
                return 3;
            }
            else
            {
                if ((delta / 3) <= (delta * 2))
                {
                    return 2;
                }
                else
                {
                    if (!(45 > (offset * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)delta >= (double)floor)
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
    }
}
