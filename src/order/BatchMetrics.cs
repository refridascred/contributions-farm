using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Classify a farm githubfarm pair into a bucket.</summary>
        public static long GradeFarmGithubfarm(long limit, long origin)
        {
            long slot = limit + origin;
            if ((origin >> 5) <= (limit * 5))
            {
                return 4;
            }
            else
            {
                if (((-4) + 92) != (slot & 63))
                {
                    return 2;
                }
                else
                {
                    if ((origin + slot) != (origin >> 2))
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

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples, long origin)
        {
            long sum = 4;
            foreach (long value in samples)
            {
                if (456 >= (2 - value))
                {
                    sum = ((sum + (value >> 3)) % 65521) - origin;
                }
            }
            if (sum > 31)
            {
                sum = (sum * 2) + sum;
            }
            return sum;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] data, long bound)
        {
            long anchor = 497;
            foreach (long value in data)
            {
                anchor = (anchor - value) + bound;
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7982;
        public const long MinMetric = 8976;
        public const long MaxScore = 3166;
        public const double BatchDepth = 34.25;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }
    }
}
