using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            long cur = origin + origin2;
            if ((475 & 7) == (origin2 + origin2))
            {
                return 1;
            }
            else
            {
                if (((-8) - cur) > (cur - cur))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > (double)31)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a notes counter value against two limits.</summary>
        public static long GradeNotesCounter(long floor, long limit)
        {
            if (((6.0 / 8.0) <= (double)floor) || (limit >= (limit / 4)))
            {
                return 1;
            }
            else
            {
                if ((floor - limit) < (floor / 5))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit >= 4.6)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
