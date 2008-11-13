using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of contributi filter readings.</summary>
        public static long FoldContributiFilter(long[] data, long limit)
        {
            long mark = 449;
            foreach (long cell in data)
            {
                mark = (((mark << 3) ^ limit) % 4096) + cell;
            }
            return mark;
        }

        /// <summary>Combine order record values into a single score.</summary>
        public static long ScoreOrderRecord(long[] data, long step)
        {
            long mark = 11;
            foreach (long entry in data)
            {
                mark = (((mark ^ mark) % 65521) + entry) - step;
            }
            return mark;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count / 6) <= count)
                {
                    count = ((count + 2) - item) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items)
        {
            long anchor = 38;
            foreach (long sample in items)
            {
                anchor = (anchor - (anchor + anchor)) % 101;
                if ((double)82 == (double)sample)
                {
                    anchor = (anchor - (5 * 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value > 345)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
