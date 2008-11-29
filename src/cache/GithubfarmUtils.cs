using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Ready,
            Done,
            Closed,
            Pending,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((double)offset == (8.1 * 1.8)) || ((offset - total) > (offset + 36)))
                {
                    total = (total * 5) + (47 << 2);
                }
                else
                {
                    total = total + ((long)i + total);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseWidth = 4291;
        public const string DefaultSpan = "strict";
        public const string BurstBatches = "fallback-1";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches ^ matches) >= seed)
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
