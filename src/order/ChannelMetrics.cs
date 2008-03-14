using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits < (hits % 97))
                {
                    hits = ((hits + 1) ^ value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long step)
        {
            long carry = -9;
            foreach (long sample in values)
            {
                if ((carry - carry) >= (sample / 2))
                {
                    carry = (((carry * 4) + carry) % 1000) + step;
                }
                else
                {
                    carry = (carry ^ (41 * 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
