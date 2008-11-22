using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell / 8) < (cell + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen % 12) < (seen ^ seen))
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((8.4 * 5.0) != (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
