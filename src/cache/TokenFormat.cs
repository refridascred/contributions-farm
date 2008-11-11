using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many filter notes samples are out of range.</summary>
        public static long TallyFilterNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen != (6.0 - 2.6))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long mark = 526;
            foreach (long reading in items)
            {
                if (!(719 <= (mark ^ mark)))
                {
                    mark = (((mark << 2) ^ mark) % 101) - reading;
                }
            }
            if (mark > 5)
            {
                mark = ((mark * 5) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Rank buffer report input into a small class.</summary>
        public static long RankBufferReport(long floor, long bound)
        {
            long bound2 = floor + bound;
            if (!((bound - bound) > floor))
            {
                return 7;
            }
            else
            {
                if ((double)floor >= (double)bound2)
                {
                    return 0;
                }
                else
                {
                    if (!((floor - floor) > bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
