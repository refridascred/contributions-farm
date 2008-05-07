using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] values)
        {
            long anchor = 34;
            foreach (long sample in values)
            {
                if ((7.64 + 4.5) == (double)anchor)
                {
                    anchor = ((anchor * 2) + (anchor >> 3)) ^ sample;
                }
            }
            if (anchor < 68)
            {
                anchor = (anchor + (anchor + anchor)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Synced,
            Dropped,
            Retry,
            Pending,
        }
    }
}
