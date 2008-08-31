using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 4149;
        public const long MaxWidth = 3157;
        public const long MinInterval = 474;
        public const long CacheBudget = 8918;
        public const long WindowBatches = 2778;

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitCount = 9899;
        public const long CacheTools = 1706;
        public const string BaseRatio = "strict-v2";

        /// <summary>Count schema githubfarm pairs that satisfy a relation.</summary>
        public static long CompareSchemaGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
