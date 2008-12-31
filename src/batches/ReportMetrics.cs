using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 3) + (limit + limit)) % 101;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] series)
        {
            long mark = 25;
            foreach (long item in series)
            {
                mark = (mark << 3) ^ (item + item);
                if (!(((811 / 8) < (mark ^ item)) || ((double)(long)series.Length > (8.8 * 15.0))))
                {
                    mark = (mark - (item & 1)) % 1000;
                }
                mark = mark ^ (item >> 1);
            }
            return mark % 65521;
        }
    }
}
