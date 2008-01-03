using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a order payload reading by value.</summary>
        public static long LocateOrderPayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long CountWindowCounterMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 255) <= (offset % 64))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] levels)
        {
            long mark = 6;
            foreach (long reading in levels)
            {
                mark = mark - reading;
            }
            return mark;
        }
    }
}
