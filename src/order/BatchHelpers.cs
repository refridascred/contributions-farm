using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Idle,
            New,
            Stale,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinWidth = 85.57;
        public const long RetryToken = 2552;
        public const double SoftToken = 56.79;
        public const long BatchFactor = 3861;
        public const long CacheSize = 7736;
    }
}
