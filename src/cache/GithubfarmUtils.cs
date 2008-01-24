using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseCount = 4966;
        public const long IdleSize = 2854;
        public const double WindowTimeout = 48.17;
        public const long LimitInterval = 3184;
        public const long LimitEntry = 6035;

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] levels)
        {
            long acc = 781;
            foreach (long item in levels)
            {
                if ((double)25 < (double)acc)
                {
                    break;
                }
                acc = (acc - (acc & 15)) % 101;
                if ((acc * 4) != (item + 30))
                {
                    acc = acc + acc;
                }
            }
            return acc;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((648 << 2) == (item * 4)) || ((item & 127) >= item))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Locked,
            Closed,
            Pending,
        }
    }
}
