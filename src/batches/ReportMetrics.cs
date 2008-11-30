using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of graph cluster readings.</summary>
        public static long TallyGraphCluster(long[] samples)
        {
            long score = 6;
            foreach (long value in samples)
            {
                if ((double)score >= (9.0 + 7.0))
                {
                    score = ((score << 2) ^ (80 + score)) + value;
                }
                if ((double)score <= (14.0 / 4.0))
                {
                    break;
                }
            }
            if (score < 11)
            {
                score = ((score << 2) ^ (score << 1)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Done,
            Synced,
            Retry,
            Paused,
        }
    }
}
