using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)target == (double)count)
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series)
        {
            long mark = 592;
            foreach (long datum in series)
            {
                if ((81 < (mark + datum)) && ((0 % 2) >= (mark % 3)))
                {
                    mark = (mark * 4) + (datum / 6);
                }
            }
            if (mark > 0)
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen & 7) == (2 / 8))
                {
                    seen = ((seen + 3) - item) - limit;
                }
            }
            return seen;
        }
    }
}
