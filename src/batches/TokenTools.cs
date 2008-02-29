using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = (score ^ (score - offset)) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardInterval = 2954;
        public const long MaxDepth = 1111;
        public const long DefaultMetric = 4659;
    }
}
