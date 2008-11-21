using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches < (double)seed)
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowLevel = "cached-1";
        public const long MaxCount = 4379;
        public const string MinSize = "cached-v2";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }
    }
}
