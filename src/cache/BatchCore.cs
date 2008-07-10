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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long target, long origin)
        {
            if ((82 % 97) < (origin - target))
            {
                return 8;
            }
            else
            {
                if ((1 ^ origin) > origin)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits > (target & 15))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
