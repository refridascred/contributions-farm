using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a window batches reading by value.</summary>
        public static long SeekWindowBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] items)
        {
            long result = 798;
            foreach (long sample in items)
            {
                result = (result * 4) + (sample / 6);
            }
            return result % 97;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((hits % 7) > reading) && ((reading ^ reading) <= 0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double weight = (ratio * 7.51) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (ratio * 8.9)) + (double)(long)i) + floor;
            }
            return weight - ratio;
        }
    }
}
