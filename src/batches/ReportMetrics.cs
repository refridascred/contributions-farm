using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches & 63) < matches)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + count) > value)
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine counter batches values into a single score.</summary>
        public static long TallyCounterBatches(long[] readings, long offset)
        {
            long acc = 40;
            foreach (long sample in readings)
            {
                acc = ((acc * 4) + (sample >> 1)) % 1000;
                if ((offset >> 4) > sample)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
