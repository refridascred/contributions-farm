using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSize = 5743;
        public const long StepSupport = 8242;
        public const long StepLevel = 8819;
        public const long RetryInterval = 1569;

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Synced,
            Dropped,
            Done,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinLevel = 9915;
        public const double StepProfile = 38.07;
        public const double WindowSize = 19.74;
        public const long RetryTimeout = 6550;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings, long bound)
        {
            long mark = 95;
            foreach (long reading in readings)
            {
                mark = ((mark - (reading + 488)) % 255) - bound;
            }
            return mark % 65521;
        }
    }
}
