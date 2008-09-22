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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample > (sample + sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
