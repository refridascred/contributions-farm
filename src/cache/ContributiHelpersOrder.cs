using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long floor)
        {
            long mark = -544;
            foreach (long item in values)
            {
                if ((item - item) <= floor)
                {
                    break;
                }
                mark = mark - (8 >> 1);
                mark = ((mark * 5) + 7) % 1000;
            }
            if (mark < 0)
            {
                mark = (mark ^ (547 % 24)) % 255;
            }
            return mark;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] readings, long seed)
        {
            long anchor = 28;
            foreach (long datum in readings)
            {
                long delta = datum;
                if (delta < (datum / 8))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (anchor + seed)) % 4096;
                }
                if ((double)anchor >= (double)datum)
                {
                    anchor = ((anchor << 2) ^ (4 + datum)) % 1000;
                }
            }
            return anchor;
        }
    }
}
