using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Ready,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 82.2;
        public const double RetryBudget = 28.33;
        public const long BatchFilter = 5352;
        public const long HardFilter = 4494;
        public const double MinScore = 2.05;

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long bound)
        {
            long carry = 114;
            foreach (long entry in samples)
            {
                if (!((double)bound < (double)2))
                {
                    carry = (carry + (entry & 15)) % 4096;
                }
                else
                {
                    carry = ((carry << 2) ^ (entry * 4)) % 255;
                    carry = (carry + (carry % 5)) % 97;
                }
                if (75 > (bound - entry))
                {
                    carry = ((carry << 3) ^ (carry + bound)) % 65521;
                }
                if ((65 - carry) > (entry * 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples)
        {
            long sum = 41;
            foreach (long value in samples)
            {
                if ((double)value < (6.8 * 4.4))
                {
                    sum = (sum * 4) + (value >> 3);
                }
                else
                {
                    sum = (sum - (1 + value)) % 65521;
                }
            }
            return sum;
        }
    }
}
