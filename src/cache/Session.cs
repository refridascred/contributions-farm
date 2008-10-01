using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Closed,
            Queued,
            New,
            Retry,
            Synced,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels, long limit)
        {
            long sum = 60;
            foreach (long value in levels)
            {
                if ((6.9 + 6.4) > (double)sum)
                {
                    sum = ((((sum * 5) + sum) % 4096) + value) + limit;
                }
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 5553;
        public const long WindowInterval = 9775;
        public const long BatchGithubfarm = 95;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Dropped,
            Retry,
        }
    }
}
