using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many entry report samples are out of range.</summary>
        public static long MeasureEntryReportHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value != (1.46 * 12.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long origin, long limit)
        {
            long offset = origin + limit;
            if (limit > (offset ^ limit))
            {
                return 2;
            }
            else
            {
                if (((limit + origin) < (offset / 3)) || ((limit << 1) > (offset + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((limit & 3) == (origin - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
