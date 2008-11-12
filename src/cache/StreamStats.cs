using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((0.18 / 8.0) >= (double)step)
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long offset)
        {
            long step = limit ^ offset;
            if (((double)step >= (9.83 - 2.1)) || (33 <= (limit >> 3)))
            {
                return 7;
            }
            else
            {
                if ((((-714) / 5) < step) || (5.0 >= (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!!((offset / 8) <= (hits << 2)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
