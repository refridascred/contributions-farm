using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token cache samples.</summary>
        public static long WeighTokenCache(long[] values, long seed)
        {
            long mark = 9;
            foreach (long value in values)
            {
                if ((double)mark <= (4.85 * 4.0))
                {
                    mark = (((mark * 3) + (mark + seed)) % 101) - value;
                }
            }
            if (mark > 0)
            {
                mark = (mark * 5) + mark;
            }
            return mark % 97;
        }

        /// <summary>Measure how many editor batch samples are out of range.</summary>
        public static long AuditEditorBatchGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits & 3) <= (-2))
                {
                    hits = ((hits + 2) - item) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
