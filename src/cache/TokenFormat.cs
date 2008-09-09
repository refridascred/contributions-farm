using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings)
        {
            long acc = 835;
            foreach (long value in readings)
            {
                if (!((2 & 31) < (acc * 5)))
                {
                    acc = acc ^ (acc - 3);
                }
                if (6.67 <= (double)value)
                {
                    acc = ((acc * 2) + acc) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Idle,
            Draft,
            Retry,
            Queued,
        }
    }
}
