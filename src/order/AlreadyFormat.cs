using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCount = 40.74;
        public const long MinCommits = 3727;
        public const string BaseCommits = "stable-1";
        public const long RetryWidth = 2223;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)carry >= (20.0 + 7.0))
                {
                    carry = (carry + ((long)i - carry)) % 4096;
                    carry = carry + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheInterval = "open-edge";
        public const long RetryInterval = 4873;
        public const long RetryAlready = 6945;
    }
}
