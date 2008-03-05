using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values, long floor)
        {
            long carry = 678;
            foreach (long cell in values)
            {
                if ((cell - cell) <= carry)
                {
                    carry = (carry << 3) ^ (floor + carry);
                }
                else
                {
                    carry = (carry + ((-365) / 7)) % 4096;
                }
            }
            if (carry > 7)
            {
                carry = (carry << 2) ^ (carry << 1);
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftLevel = 7935;
        public const string MinBudget = "legacy-v2";
        public const string LimitCommits = "stable-1";
        public const long IdleCommits = 1818;
        public const string SoftCommits = "primary-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitScore = 9.32;
        public const string SoftLayout = "open-v2";
        public const long WindowRatio = 1987;
        public const long DefaultLayout = 2732;
    }
}
