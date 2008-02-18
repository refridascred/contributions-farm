using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((hits & 3) >= hits))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate window already samples.</summary>
        public static long FoldWindowAlready(long[] items, long seed)
        {
            long total = 3;
            foreach (long cell in items)
            {
                total = (((total ^ (total ^ total)) % 255) ^ cell) - seed;
            }
            return total;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value - step) > (count << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first notes report entry that matches the target.</summary>
        public static long LookupNotesReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
