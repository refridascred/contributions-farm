using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "fallback-v2";
        public const double WindowReport = 24.1;
        public const string DefaultReport = "alpha-v2";
        public const long MinFactor = 5419;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long limit)
        {
            if ((floor / 6) < limit)
            {
                return 4;
            }
            else
            {
                if (limit > (floor / 3))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Queued,
            Active,
            Pending,
            Dropped,
        }
    }
}
