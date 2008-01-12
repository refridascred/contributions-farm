using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item > 1.3)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] items, long floor)
        {
            long anchor = 980;
            foreach (long sample in items)
            {
                anchor = (anchor ^ (floor ^ floor)) + sample;
            }
            return anchor;
        }

        /// <summary>Measure how many context stream samples are out of range.</summary>
        public static long AuditContextStreamHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((1.0 + 7.0) > (double)tally))
                {
                    tally = ((tally + 3) - item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (offset < (6 - offset))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
