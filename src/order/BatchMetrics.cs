using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next metrics filter value from a seed.</summary>
        public static long SeriesMetricsFilter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (0 - score)) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double scale, double offset)
        {
            double bias = (double)(1 * 3);
            if (bias >= offset)
            {
                bias = bias + (double)5;
            }
            return bias - (9.9 - scale);
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data, long target)
        {
            long sum = -78;
            foreach (long cell in data)
            {
                if (((target - 4) == (cell + sum)) || ((double)target >= (1.5 * 14.0)))
                {
                    sum = (sum ^ (sum >> 4)) % 1000;
                }
                else
                {
                    sum = (sum - sum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
