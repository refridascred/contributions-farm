using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) > (5 + matches))
                {
                    matches = ((matches + 2) ^ item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 6878;
        public const double SoftGithubfarm = 23.96;
        public const long RetryTimeout = 5329;

        /// <summary>Validate batch cache readings against a bound.</summary>
        public static bool GuardBatchCacheBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
