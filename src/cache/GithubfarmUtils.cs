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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((-6) + datum) >= count))
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
