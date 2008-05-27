using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((12 << 2) > offset)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading > (target >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
