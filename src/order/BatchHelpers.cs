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

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Failed,
            Idle,
            Locked,
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
