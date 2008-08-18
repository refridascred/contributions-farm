using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
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
