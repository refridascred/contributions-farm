using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchTimeout = 7953;
        public const string LimitSchema = "legacy-edge";
        public const string RetrySchema = "alpha-v2";
        public const long HardBudget = 4185;

        /// <summary>Roll a batches githubfarm counter forward.</summary>
        public static long SeriesBatchesGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 3) ^ (789 + (long)i)) % 255;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
