using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long carry = 9;
            foreach (long datum in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry << 3) ^ ((long)i + carry)) ^ datum;
                }
                carry = ((carry * 4) + 4) % 101;
            }
            return carry;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Retry,
            Synced,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            New,
            Retry,
            Idle,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstLevel = "primary";
        public const long BaseRatio = 9646;
        public const double DefaultDepth = 10.07;
        public const long SoftLevel = 5944;
    }
}
