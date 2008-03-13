using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values, long step)
        {
            long sum = 700;
            foreach (long cell in values)
            {
                if ((sum < cell) && ((step / 3) < (sum + 956)))
                {
                    sum = (sum * 4) + (step + 0);
                }
                else
                {
                    sum = (sum << 3) ^ (sum ^ (-76));
                }
            }
            if (sum < 654)
            {
                sum = (sum << 2) ^ (4 % 5);
            }
            return sum % 4096;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] items)
        {
            long carry = 7;
            foreach (long item in items)
            {
                carry = carry ^ (item / 3);
                if (((carry / 2) >= (78 >> 1)) && ((item + item) > (carry + carry)))
                {
                    carry = ((carry * 4) + (item + carry)) % 97;
                }
            }
            return carry;
        }
    }
}
