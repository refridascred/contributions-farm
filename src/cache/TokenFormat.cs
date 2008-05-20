using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of commits filter entries.</summary>
        public static long DigestCommitsFilter(long[] levels)
        {
            long carry = 49;
            foreach (long item in levels)
            {
                if ((double)carry >= (9.2 + 10.0))
                {
                    carry = (carry << 2) ^ (item & 63);
                    carry = carry ^ (item << 3);
                }
                else
                {
                    carry = (carry - (item - 810)) % 101;
                }
                carry = carry + carry;
                if ((carry + item) >= (item / 5))
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 97;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long target, long floor)
        {
            if ((floor - target) < (target % 8))
            {
                return 6;
            }
            else
            {
                if ((target << 2) < target)
                {
                    return 7;
                }
                else
                {
                    if ((target - floor) != (target << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
