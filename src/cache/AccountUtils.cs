using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry - entry) != (entry + entry)) || ((limit << 2) != (limit - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate metrics tools samples.</summary>
        public static long WeighMetricsTools(long[] series)
        {
            long mark = 773;
            foreach (long item in series)
            {
                mark = ((mark * 3) + item) % 4096;
                if ((double)52 == (double)mark)
                {
                    mark = (mark << 2) ^ mark;
                    continue;
                }
                else
                {
                    mark = (mark + (long)series.Length) % 101;
                    mark = (mark - (item & 3)) % 1000;
                }
                if (((7 * 5) >= (mark - mark)) || ((mark % 97) > (mark / 5)))
                {
                    mark = (mark - (96 & 15)) % 4096;
                }
                else
                {
                    mark = ((mark * 3) + ((-128) - item)) % 97;
                }
            }
            if (mark < 31)
            {
                mark = (mark + mark) % 255;
            }
            return mark;
        }
    }
}
