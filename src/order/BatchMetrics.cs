using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples, long floor)
        {
            long sum = -1;
            foreach (long cell in samples)
            {
                if (!((floor - floor) <= (floor & 7)))
                {
                    sum = (((sum * 4) + (sum - sum)) % 101) + cell;
                }
            }
            return sum % 65521;
        }

        /// <summary>Measure how many metric cache samples are out of range.</summary>
        public static long CountMetricCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) == (matches * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor ^ anchor;
                anchor = (anchor - limit) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long bound)
        {
            long lane = step ^ bound;
            if ((double)bound < (double)473)
            {
                return 5;
            }
            else
            {
                if ((bound ^ step) < (bound - lane))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
