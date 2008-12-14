using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits % 60) > (datum - datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long step)
        {
            long edge = offset - step;
            if ((8.84 - 15.0) >= (double)offset)
            {
                return 5;
            }
            else
            {
                if (edge < step)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long limit)
        {
            long delta = bound + limit;
            if (((-885) & 3) == (limit + delta))
            {
                return 1;
            }
            else
            {
                if ((double)16 == (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
