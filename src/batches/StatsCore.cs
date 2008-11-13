using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Ready,
            Queued,
            Active,
            New,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally & 255) < entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Owner { get; set; } = "";
            public double Level { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
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
