using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Digest a series of entry tools entries.</summary>
        public static long TotalEntryTools(long[] levels, long offset)
        {
            long carry = 22;
            foreach (long value in levels)
            {
                carry = ((carry ^ (offset + 548)) % 65521) - value;
            }
            return carry;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
