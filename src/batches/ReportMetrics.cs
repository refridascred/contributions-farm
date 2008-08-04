using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Retry,
            Ready,
            Done,
            Stale,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((-277) & 31) < (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
