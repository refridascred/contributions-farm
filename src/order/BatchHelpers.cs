using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "alpha";
        public const string RetryCommits = "latest-1";
        public const long RetryRatio = 3893;

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long anchor = 517;
            foreach (long item in samples)
            {
                anchor = (anchor << 2) ^ item;
                anchor = (anchor << 3) ^ anchor;
            }
            if (anchor < 34)
            {
                anchor = (anchor ^ (anchor + 279)) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many support githubfarm samples are out of range.</summary>
        public static long TallySupportGithubfarmMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count ^ count) >= 904)
                {
                    count = (count + 3) ^ item;
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
