using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] values)
        {
            long carry = -9;
            foreach (long value in values)
            {
                if ((595 >> 5) != (value + carry))
                {
                    carry = (carry + value) % 101;
                }
            }
            if (carry < 238)
            {
                carry = (carry ^ (carry % 5)) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] series, long limit)
        {
            long sum = 339;
            foreach (long item in series)
            {
                sum = sum ^ (limit ^ item);
                sum = ((sum * 3) + item) % 4096;
            }
            if (sum < 32)
            {
                sum = ((sum << 3) ^ ((-180) ^ sum)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Dropped,
            Paused,
            Locked,
            New,
        }
    }
}
