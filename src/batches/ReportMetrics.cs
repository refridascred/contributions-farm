using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the context report entries that pass the check.</summary>
        public static long CountContextReportHits(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell / 7) <= 76)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] data, long floor)
        {
            long acc = 86;
            foreach (long item in data)
            {
                acc = (((acc + ((-549) & 255)) % 255) ^ item) + floor;
            }
            return acc % 97;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((origin << 1) >= (origin * 3)))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
