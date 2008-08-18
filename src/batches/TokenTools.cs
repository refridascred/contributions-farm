using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] values)
        {
            long sum = 274;
            foreach (long item in values)
            {
                if ((sum << 1) >= (item & 1))
                {
                    sum = ((sum << 2) ^ (sum >> 1)) % 101;
                }
                if (((double)item == (double)sum) || ((sum + item) <= sum))
                {
                    sum = (sum * 2) + sum;
                }
            }
            return sum;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values, long target)
        {
            long carry = 6;
            foreach (long entry in values)
            {
                carry = (carry ^ (entry + 60)) % 65521;
                carry = (carry * 3) + (target * 3);
            }
            if (carry < 29)
            {
                carry = ((carry * 4) + (target >> 2)) % 65521;
            }
            return carry;
        }
    }
}
