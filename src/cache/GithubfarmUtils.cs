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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen >> 3) >= seed) || ((cell >> 4) >= (seed - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
