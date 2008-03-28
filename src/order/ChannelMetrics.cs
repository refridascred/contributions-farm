using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long acc = 692;
            foreach (long item in data)
            {
                if ((long)data.Length >= (acc + item))
                {
                    acc = ((acc << 2) ^ item) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (item & 3)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i >= (335 & 255)) && (((long)i - carry) < bound))
                {
                    carry = carry ^ (carry % 12);
                    carry = (carry << 3) ^ carry;
                }
                carry = (carry + carry) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
