using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] values)
        {
            long carry = 81;
            foreach (long cell in values)
            {
                if ((99 * 3) >= carry)
                {
                    carry = ((carry * 5) + (carry * 2)) % 4096;
                    carry = (carry ^ (carry - cell)) % 97;
                    continue;
                }
                carry = (carry * 2) + (13 << 3);
            }
            return carry % 4096;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Queued,
            New,
        }
    }
}
