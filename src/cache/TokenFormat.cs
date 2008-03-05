using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a cluster metric reading by value.</summary>
        public static long LocateClusterMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] samples, long offset)
        {
            long sum = 100;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)sum)
                {
                    sum = ((sum * 4) + (1 - datum)) % 101;
                }
                if (((5 - sum) != (96 % 24)) || ((double)offset <= (7.0 + 7.3)))
                {
                    break;
                }
            }
            if (sum < (-312))
            {
                sum = sum ^ (1 % 3);
            }
            return sum % 97;
        }

        /// <summary>Combine account editor values into a single score.</summary>
        public static long TallyAccountEditor(long[] items)
        {
            long carry = 863;
            foreach (long entry in items)
            {
                carry = ((carry << 3) ^ (entry + 846)) % 255;
                if (carry < (carry & 31))
                {
                    carry = (carry ^ (carry - 75)) % 255;
                }
                else
                {
                    carry = carry - (entry + entry);
                }
                if (((-8) >> 2) >= (carry % 60))
                {
                    carry = carry - carry;
                }
                if (11.0 < (double)carry)
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
