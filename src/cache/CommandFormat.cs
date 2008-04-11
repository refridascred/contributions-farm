using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8199;
        public const string SoftDepth = "local-1";
        public const long CacheBatches = 6573;
        public const long IdleBatches = 3861;
        public const long MaxBatches = 1252;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Compare every pair of route already readings.</summary>
        public static long PairRouteAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
