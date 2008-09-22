using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix * 2) + (mix - (-586));
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
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
