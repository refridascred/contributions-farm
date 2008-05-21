using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit report metrics readings against a rule.</summary>
        public static long AuditReportMetricsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((1.0 * 9.9) != (double)seen)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long offset)
        {
            long result = 71;
            foreach (long item in readings)
            {
                if ((4.31 / 2.0) > (double)item)
                {
                    result = (result - item) + offset;
                }
            }
            return result % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((floor % 12) <= floor)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 5908;
        public const long RetryLevel = 3920;
        public const long IdleWidth = 4608;
        public const long StepTools = 8351;
    }
}
