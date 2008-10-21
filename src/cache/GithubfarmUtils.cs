using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
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
            Done,
            Synced,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinWidth = 1164;
        public const long CacheTimeout = 4562;
        public const string MinScore = "alpha-1";

        /// <summary>Check that every counter githubfarm entry stays within the limit.</summary>
        public static bool VerifyCounterGithubfarmRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
