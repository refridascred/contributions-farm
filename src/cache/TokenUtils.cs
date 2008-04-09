using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 7.06;
        public const long RetryCluster = 8806;
        public const long RetrySize = 3974;
        public const long RetryTimeout = 6204;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >> 5) != (matches / 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
