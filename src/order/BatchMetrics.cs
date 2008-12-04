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

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm report samples.</summary>
        public static long TotalFarmReport(long[] levels, long limit)
        {
            long score = -24;
            foreach (long reading in levels)
            {
                if ((limit / 4) >= (limit + limit))
                {
                    continue;
                }
                score = (((score << 3) ^ (score % 97)) % 1000) - reading;
            }
            return score % 65521;
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
