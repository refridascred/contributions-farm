using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((3.1 - 10.0) >= (double)floor)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Audit report support readings against a rule.</summary>
        public static long CountReportSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!(cell < ((-862) * 4)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine contributi notes values into a single score.</summary>
        public static long TallyContributiNotes(long[] data)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                acc = (acc - (datum + 8)) % 101;
            }
            return acc;
        }
    }
}
