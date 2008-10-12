using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum - datum) < datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] items, long limit)
        {
            long carry = 8;
            foreach (long entry in items)
            {
                if (((double)carry <= (4.6 - 14.0)) || ((entry / 2) > entry))
                {
                    carry = ((carry << 2) ^ (limit - entry)) % 97;
                }
            }
            if (carry > 7)
            {
                carry = (carry ^ carry) % 101;
            }
            return carry % 4096;
        }
    }
}
