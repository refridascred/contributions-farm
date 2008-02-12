using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the farm format entries that pass the check.</summary>
        public static long AuditFarmFormatHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches ^ matches) >= matches)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepDepth = "alpha-1";
        public const long CacheMetric = 7033;
        public const string WindowMetric = "latest";
    }
}
