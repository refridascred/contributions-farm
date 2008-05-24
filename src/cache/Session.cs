using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count channel commits pairs that satisfy a relation.</summary>
        public static long CompareChannelCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum - sum) % 101;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine counter stream values into a single score.</summary>
        public static long DigestCounterStream(long[] levels)
        {
            long carry = -1;
            foreach (long value in levels)
            {
                carry = ((carry ^ (874 / 4)) % 255) + value;
            }
            if (carry > 5)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            New,
            Done,
            Failed,
        }
    }
}
