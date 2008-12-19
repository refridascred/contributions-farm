using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every support notes entry stays within the limit.</summary>
        public static bool GuardSupportNotesBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Pending,
            New,
            Dropped,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long offset)
        {
            if (((-486) << 1) >= (offset - target))
            {
                return 5;
            }
            else
            {
                if ((10 + target) > (target / 3))
                {
                    return 8;
                }
                else
                {
                    if ((7.8 - 3.33) <= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
