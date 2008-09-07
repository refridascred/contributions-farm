using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Failed,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Compare every pair of cluster cache readings.</summary>
        public static long MatchClusterCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
