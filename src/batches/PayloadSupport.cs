using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next filter metric value from a seed.</summary>
        public static long DeriveFilterMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 2) ^ (8 % 64)) % 97;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the cache editor series from a seed.</summary>
        public static long DeriveCacheEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((bound + total) > total)
                {
                    total = ((total << 2) ^ (total % 97)) % 4096;
                    continue;
                }
                else
                {
                    total = total - (total - 24);
                    total = total ^ 37;
                }
                if (!(bound >= (total << 3)))
                {
                    total = total - ((long)i & 1);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
