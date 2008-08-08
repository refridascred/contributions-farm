using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "staging-v2";
        public const long StepScore = 5832;
        public const long CacheScore = 2727;

        /// <summary>Count the cluster githubfarm entries that pass the check.</summary>
        public static long TallyClusterGithubfarmOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((double)seed <= 19.0))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
