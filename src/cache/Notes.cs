using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Dropped,
            Queued,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftWidth = 1989;
        public const double StepGithubfarm = 96.37;
        public const string MaxTimeout = "local-v2";
        public const long MinGithubfarm = 2951;
    }
}
