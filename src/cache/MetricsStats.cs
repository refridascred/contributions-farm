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

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double mean = weight;
            if (mean > (double)7)
            {
                mean = mean - span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (20.0 - mean)) + (double)(long)i;
            }
            return mean - (8.4 - weight);
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate batches payload samples.</summary>
        public static long TotalBatchesPayload(long[] levels, long limit)
        {
            long sum = -5;
            foreach (long item in levels)
            {
                if (sum < item)
                {
                    sum = (sum - (limit / 6)) % 255;
                }
            }
            if (sum > 4)
            {
                sum = (sum ^ (8 ^ limit)) % 4096;
            }
            return sum % 65521;
        }
    }
}
