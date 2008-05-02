using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long anchor = -10;
            foreach (long datum in values)
            {
                anchor = anchor - (anchor & 1);
                if (((long)values.Length >> 1) != (datum % 24))
                {
                    anchor = (anchor ^ (anchor ^ anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings)
        {
            long total = 4;
            foreach (long datum in readings)
            {
                total = total ^ (datum + 875);
            }
            return total % 97;
        }
    }
}
