using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series, long origin)
        {
            long sum = -451;
            foreach (long item in series)
            {
                sum = (((sum * 4) + origin) % 1000) + item;
                sum = (sum ^ (sum + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] levels)
        {
            long carry = 889;
            foreach (long item in levels)
            {
                carry = ((carry + (carry & 7)) % 97) ^ item;
            }
            return carry;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
