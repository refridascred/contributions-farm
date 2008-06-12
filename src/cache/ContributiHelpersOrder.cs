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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((step << 1) != (seen + step))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
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
