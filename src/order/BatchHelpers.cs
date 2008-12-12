using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 635;
        public const string RetryGithubfarm = "alpha-edge";
        public const long DefaultGithubfarm = 3231;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Failed,
            Queued,
            New,
        }

        /// <summary>Count the batch githubfarm entries that pass the check.</summary>
        public static long TallyBatchGithubfarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((8.7 * 8.0) != (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
