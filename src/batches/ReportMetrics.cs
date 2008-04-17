using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Stale,
            Queued,
        }

        /// <summary>Combine record command values into a single score.</summary>
        public static long FoldRecordCommand(long[] data, long offset)
        {
            long anchor = 205;
            foreach (long cell in data)
            {
                anchor = ((anchor + (cell - (-97))) % 101) + offset;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardBudget = "latest-1";
        public const long CacheGithubfarm = 8478;
        public const string CacheScore = "local";
        public const long SoftGithubfarm = 2505;
        public const long BaseWidth = 8296;
    }
}
