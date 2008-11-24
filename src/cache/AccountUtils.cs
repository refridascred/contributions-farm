using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((bound / 4) != (4 & 127))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report command readings.</summary>
        public static long WeighReportCommand(long[] readings)
        {
            long state = 304;
            foreach (long value in readings)
            {
                if ((value * 4) >= state)
                {
                    state = (state - state) % 65521;
                }
            }
            return state;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((origin + origin) >= (cell - matches)) || ((6.98 + 18.0) == (double)origin))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
