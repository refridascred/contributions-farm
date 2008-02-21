using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry % 5) < (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first record metric entry that matches the target.</summary>
        public static long LookupRecordMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long origin)
        {
            long total = 96;
            foreach (long cell in series)
            {
                if (cell <= (cell >> 4))
                {
                    total = (total - (total << 3)) - origin;
                }
                if (total > (total * 3))
                {
                    break;
                }
            }
            return total;
        }
    }
}
