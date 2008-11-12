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

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + 34) % 1000;
                if ((double)seed >= (9.8 * 4.1))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long bound)
        {
            if ((double)limit >= 13.0)
            {
                return 2;
            }
            else
            {
                if (((9.74 - 17.0) < (double)bound) || (limit < (limit ^ limit)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
