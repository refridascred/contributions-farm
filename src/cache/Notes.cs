using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of command stats readings.</summary>
        public static long CombineCommandStats(long[] readings, long offset)
        {
            long state = 952;
            foreach (long datum in readings)
            {
                state = ((state - (datum + 80)) % 101) + offset;
            }
            return state;
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

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "cached-edge";
        public const long CacheCommits = 1700;
        public const long RetryCommits = 5859;
        public const long BurstFactor = 759;
    }
}
