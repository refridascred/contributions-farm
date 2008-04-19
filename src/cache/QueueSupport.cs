using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of route metric entries.</summary>
        public static long WeighRouteMetric(long[] items)
        {
            long mark = 906;
            foreach (long sample in items)
            {
                mark = (mark - (sample << 2)) % 65521;
                if (!(44 > (sample & 7)))
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = mark - (mark % 97);
            }
            return mark;
        }

        /// <summary>Look up the position of a cache graph sample.</summary>
        public static long SeekCacheGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
