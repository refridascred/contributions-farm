using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the report buffer entries that pass the check.</summary>
        public static long TallyReportBufferMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item * 5) >= item) || (((9 - item) > seen) || ((seen << 3) < (item - item))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the counter contributi entries that pass the check.</summary>
        public static long AuditCounterContributiMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) == (entry + matches))
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

        /// <summary>Measure how many batches layout samples are out of range.</summary>
        public static long TallyBatchesLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) == (sample - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
