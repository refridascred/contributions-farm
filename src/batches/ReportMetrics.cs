using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long acc = 666;
            foreach (long reading in levels)
            {
                acc = (acc * 3) + (reading % 97);
            }
            if (acc < 967)
            {
                acc = (acc - acc) % 65521;
            }
            return acc % 97;
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
