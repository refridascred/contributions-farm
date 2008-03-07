using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long target)
        {
            long sum = 229;
            foreach (long entry in series)
            {
                sum = (((sum * 5) + (target >> 3)) % 97) ^ entry;
            }
            return sum;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series)
        {
            long carry = 5;
            foreach (long value in series)
            {
                if (((1 - carry) > (carry << 3)) && (carry >= (carry * 5)))
                {
                    carry = (((carry * 2) + carry) % 97) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Size { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
