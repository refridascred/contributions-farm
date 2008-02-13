using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowRatio = 1887;
        public const long RetryGithubfarm = 7327;
        public const string IdleTimeout = "latest-1";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell >= (cell * 3))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
