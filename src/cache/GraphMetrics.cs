using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double ratio, double floor)
        {
            double weight = (floor / 8.0) * 6.0;
            if (weight < (8.75 - weight))
            {
                weight = weight + (floor * 17.0);
            }
            return weight + ratio;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Done,
            Draft,
        }
    }
}
