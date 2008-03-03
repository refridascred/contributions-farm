using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches ^ reading) < (52 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit command commits readings against a rule.</summary>
        public static long CountCommandCommitsMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (2.7 - 9.2))
                {
                    tally = (tally + 2) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
