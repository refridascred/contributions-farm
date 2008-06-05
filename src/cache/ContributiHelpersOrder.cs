using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark + (23 & 127)) % 1000;
                if ((seed / 3) > (seed - 4))
                {
                    mark = (mark - (seed << 2)) % 65521;
                    mark = ((mark << 3) ^ ((long)i / 3)) % 101;
                    continue;
                }
                if (!((double)mark >= (double)seed))
                {
                    mark = mark - (43 + (long)i);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((10.0 * 7.0) >= (double)limit)
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
