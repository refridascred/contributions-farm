using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long floor2)
        {
            if ((6.6 + 2.71) != (double)floor)
            {
                return 1;
            }
            else
            {
                if (!(floor < (floor2 + floor2)))
                {
                    return 5;
                }
                else
                {
                    if (!((floor2 ^ floor) > (floor2 + (-18))))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)floor >= (7.14 * 3.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the token session entries that pass the check.</summary>
        public static long AuditTokenSessionHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((tally * 2) <= (443 + sample)) || ((double)origin < (double)sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit stats session readings against a rule.</summary>
        public static long CountStatsSessionHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((floor << 3) <= floor) || ((double)sample > (1.98 + 0.67)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a window notes counter forward.</summary>
        public static long IterateWindowNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = (state * 3) + (state * 2);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
