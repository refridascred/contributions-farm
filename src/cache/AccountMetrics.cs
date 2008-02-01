using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] levels, long target)
        {
            long carry = 70;
            foreach (long reading in levels)
            {
                carry = (carry + (target - carry)) % 1000;
                if ((13.0 * 4.02) > (double)reading)
                {
                    break;
                }
            }
            if (carry > 13)
            {
                carry = carry + 67;
            }
            return carry;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Retry,
            Active,
            New,
            Stale,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed * 2) >= (seed - (long)i))
                {
                    acc = acc + (acc * 3);
                }
                acc = (acc - (seed + acc)) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate profile githubfarm readings against a bound.</summary>
        public static bool ValidateProfileGithubfarmBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Draft,
            Active,
            Stale,
            Pending,
        }
    }
}
