using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 3) ^ (carry + seed)) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell < (origin & 3))
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

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value != (9.12 + 8.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
