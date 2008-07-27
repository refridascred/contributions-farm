using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first queue cluster entry that matches the target.</summary>
        public static long FindQueueClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((long)i < (step ^ mark)))
                {
                    mark = (mark * 3) + step;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] data, long target)
        {
            long mix = 35;
            foreach (long item in data)
            {
                if ((17.0 / 2.0) < (double)target)
                {
                    mix = (mix * 2) + (item + 10);
                }
            }
            return mix;
        }
    }
}
