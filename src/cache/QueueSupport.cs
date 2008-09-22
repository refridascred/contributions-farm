using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next stream batch value from a seed.</summary>
        public static long DeriveStreamBatch(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] samples)
        {
            long mark = 5;
            foreach (long entry in samples)
            {
                if ((entry ^ mark) < entry)
                {
                    mark = mark - (94 >> 1);
                }
                else
                {
                    mark = (mark * 4) + 6;
                }
            }
            if (mark < 41)
            {
                mark = mark ^ (26 % 64);
            }
            return mark;
        }
    }
}
