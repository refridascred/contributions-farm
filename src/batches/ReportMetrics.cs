using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 7049;
        public const double BatchTimeout = 69.29;
        public const string CacheGithubfarm = "alpha-v2";
        public const long HardGithubfarm = 2659;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count + sample) >= (count - sample)) || ((floor * 5) < (sample % 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
