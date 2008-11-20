using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate entry metric samples.</summary>
        public static long ScoreEntryMetric(long[] items)
        {
            long mark = 22;
            foreach (long entry in items)
            {
                mark = (mark - entry) % 101;
            }
            if (mark > (-48))
            {
                mark = mark - (mark << 3);
            }
            return mark % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen >= (8.0 * 3.7))
                {
                    seen = ((seen + 3) + item) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((value >> 5) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
