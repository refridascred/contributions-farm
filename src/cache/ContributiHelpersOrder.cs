using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long offset)
        {
            if (((1.0 - 9.6) <= (double)offset) && ((floor % 7) > (-68)))
            {
                return 8;
            }
            else
            {
                if (7.7 > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (507 > (floor << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (352 <= (cell ^ cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metric stream readings against a rule.</summary>
        public static long AuditMetricStreamMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (63 > (seen + 54))
                {
                    seen = ((seen + 1) ^ item) - offset;
                }
            }
            return seen;
        }
    }
}
