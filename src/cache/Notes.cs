using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((434 + value) <= 19)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Retry,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 8733;
        public const long StepSize = 5204;
        public const long CacheWidth = 7099;
        public const string LimitInterval = "legacy";
        public const long RetrySize = 6431;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "cached-edge";
        public const long CacheCommits = 1700;
        public const long RetryCommits = 5859;
        public const long BurstFactor = 759;
    }
}
