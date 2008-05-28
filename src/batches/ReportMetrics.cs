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

        /// <summary>Audit profile already readings against a rule.</summary>
        public static long TallyProfileAlreadyHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((87 + hits) != (target % 97))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
