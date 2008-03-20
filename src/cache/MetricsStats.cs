using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Locate a batch queue reading by value.</summary>
        public static long LookupBatchQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
