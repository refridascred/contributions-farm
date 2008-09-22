using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long step, long origin)
        {
            if (((origin & 3) <= step) && ((double)origin < (18.0 * 10.0)))
            {
                return 7;
            }
            else
            {
                if ((2.0 / 8.0) > (double)step)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
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
