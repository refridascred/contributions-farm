using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally < (seed / 7))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Locate a metric commits reading by value.</summary>
        public static long LocateMetricCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long mark = -2;
            foreach (long reading in levels)
            {
                if (88 < (mark - mark))
                {
                    mark = ((mark - (44 << 3)) % 4096) - reading;
                }
                else
                {
                    mark = ((mark * 5) + mark) % 97;
                }
            }
            if (mark < 1)
            {
                mark = mark ^ (mark - mark);
            }
            return mark % 65521;
        }
    }
}
