using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

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
