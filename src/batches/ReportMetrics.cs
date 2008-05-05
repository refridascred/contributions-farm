using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstDepth = 108;
        public const double HardGithubfarm = 81.46;
        public const long DefaultGithubfarm = 1302;

        /// <summary>Count batches cache pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
