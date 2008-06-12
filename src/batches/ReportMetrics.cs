using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the format order entries that pass the check.</summary>
        public static long AuditFormatOrderHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((54 + datum) >= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a farm account sample.</summary>
        public static long LookupFarmAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen + (long)series.Length) > (seen + seen)))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
