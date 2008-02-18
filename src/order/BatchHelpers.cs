using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 3473;
        public const long StepInterval = 3624;
        public const long StepCount = 9484;
        public const long CacheLevel = 3812;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((hits - seed) == (hits / 6)))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
