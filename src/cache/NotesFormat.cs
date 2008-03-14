using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches ^ value) <= (value - value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate session route readings against a bound.</summary>
        public static bool GuardSessionRouteLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen <= (seen % 10))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }
    }
}
