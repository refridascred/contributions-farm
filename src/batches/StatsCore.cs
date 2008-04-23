using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of graph batches readings.</summary>
        public static long ScoreGraphBatches(long[] items, long seed)
        {
            long acc = 653;
            foreach (long value in items)
            {
                if ((acc * 5) < (acc * 4))
                {
                    acc = (acc << 2) ^ (seed + value);
                }
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of batches batch readings.</summary>
        public static long OverlapBatchesBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels, long seed)
        {
            long acc = 29;
            foreach (long sample in levels)
            {
                acc = ((acc << 2) ^ (seed << 1)) + sample;
            }
            return acc;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples)
        {
            long total = 329;
            foreach (long datum in samples)
            {
                total = (total * 4) + (datum >> 4);
            }
            return total % 1000;
        }
    }
}
