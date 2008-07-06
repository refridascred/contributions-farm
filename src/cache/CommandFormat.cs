using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "legacy-1";
        public const long SoftFilter = 3676;
        public const string CacheSize = "local-1";
        public const long RetryFilter = 3300;
        public const string CacheCount = "stable-edge";

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            Active,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((7.26 * 6.5) != (double)count)
                {
                    count = (count + 1) + sample;
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
