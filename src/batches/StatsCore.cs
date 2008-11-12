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

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long step)
        {
            long gap = floor + step;
            if ((13.0 / 6.0) != (double)gap)
            {
                return 4;
            }
            else
            {
                if ((double)gap <= 8.1)
                {
                    return 0;
                }
                else
                {
                    if ((step >> 3) != (gap + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item <= 6.8)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
