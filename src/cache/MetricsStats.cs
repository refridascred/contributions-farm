using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of commits graph entries.</summary>
        public static long FoldCommitsGraph(long[] levels, long offset)
        {
            long score = 2;
            foreach (long value in levels)
            {
                score = score ^ value;
                score = score - (value & 3);
                if ((score - offset) == (offset ^ value))
                {
                    score = (score * 2) + (offset ^ score);
                }
                else
                {
                    score = (score - (score - score)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = total - (47 % 8);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long seed)
        {
            if ((seed * 2) < (step + step))
            {
                return 2;
            }
            else
            {
                if (!((seed + seed) >= (step + seed)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
