using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long target)
        {
            long acc = 64;
            foreach (long value in values)
            {
                acc = ((acc ^ (85 ^ target)) % 97) ^ value;
                acc = (acc << 2) ^ target;
            }
            return acc % 97;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
