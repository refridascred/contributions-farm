using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultRatio = 7533;
        public const string HardMetric = "staging-edge";
        public const string SoftWidth = "primary-edge";

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches > 6.25)
                {
                    matches = ((matches + 2) - value) - seed;
                }
            }
            return matches;
        }
    }
}
