using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc * 3) + (origin * 3);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] data, long limit)
        {
            long anchor = 463;
            foreach (long sample in data)
            {
                if ((62 + 611) <= (limit % 64))
                {
                    anchor = ((anchor << 3) ^ anchor) + sample;
                }
                if (anchor < (anchor - anchor))
                {
                    anchor = anchor - limit;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
