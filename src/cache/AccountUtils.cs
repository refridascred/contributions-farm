using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum >= (datum - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell > 4.42)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
