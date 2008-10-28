using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values)
        {
            long acc = -27;
            foreach (long sample in values)
            {
                acc = (acc + acc) ^ sample;
            }
            if (acc < 5)
            {
                acc = acc + (acc - acc);
            }
            return acc;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell < (0 + limit))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
