using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 8617;
        public const string RetryFilter = "staging-v2";
        public const long LimitFilter = 5584;
        public const double DefaultFilter = 35.01;

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data)
        {
            long carry = -3;
            foreach (long cell in data)
            {
                if ((carry + carry) >= (620 / 5))
                {
                    carry = carry - (cell + 975);
                }
                else
                {
                    carry = carry + 10;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Ready,
            Draft,
            Queued,
        }
    }
}
