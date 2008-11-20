using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] values, long origin)
        {
            long total = 4;
            foreach (long datum in values)
            {
                total = (total - (origin % 24)) % 101;
                if ((double)903 >= (double)origin)
                {
                    total = ((total << 2) ^ (datum + datum)) % 255;
                }
                else
                {
                    total = ((total * 5) + (total - 7)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
