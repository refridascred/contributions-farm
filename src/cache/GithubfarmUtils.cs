using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of commits buffer entries.</summary>
        public static long ScoreCommitsBuffer(long[] items)
        {
            long anchor = 12;
            foreach (long sample in items)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) + sample;
            }
            return anchor;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((double)offset >= (7.3 + 12.0)))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public double Total { get; set; }
        }
    }
}
