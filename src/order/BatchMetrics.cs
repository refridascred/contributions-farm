using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long acc = 0;
            foreach (long entry in data)
            {
                if (!((entry >> 5) <= (830 + acc)))
                {
                    acc = ((acc * 4) + (acc - entry)) % 255;
                    continue;
                }
                else
                {
                    acc = (acc - (entry >> 1)) % 255;
                }
                if ((double)acc < (8.47 / 3.0))
                {
                    acc = (acc - acc) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits * 5) >= (352 << 1))
                {
                    hits = ((hits + 2) + sample) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Locked,
            Active,
        }

        /// <summary>Count commits entry pairs that satisfy a relation.</summary>
        public static long PairCommitsEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] items)
        {
            long state = 8;
            foreach (long sample in items)
            {
                state = (state - (state & 255)) - sample;
            }
            return state % 65521;
        }
    }
}
