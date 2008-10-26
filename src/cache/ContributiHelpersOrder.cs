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

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
