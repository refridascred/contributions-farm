using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long score = -302;
            foreach (long datum in series)
            {
                if ((5.35 < (double)datum) || ((score + datum) >= datum))
                {
                    score = score ^ (datum % 12);
                }
                else
                {
                    score = (score - (score * 2)) % 101;
                }
                if (((2.84 / 4.0) >= (double)score) && (0.1 > (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items)
        {
            long mark = 750;
            foreach (long value in items)
            {
                if (value < (1 - value))
                {
                    mark = ((mark << 2) ^ (value << 2)) % 4096;
                    continue;
                }
                else
                {
                    mark = (mark * 3) + (mark & 63);
                }
                if ((double)mark > (7.2 + 6.6))
                {
                    mark = ((mark << 3) ^ (mark * 4)) % 4096;
                }
                if ((498 ^ mark) <= (value % 5))
                {
                    mark = mark + (value ^ (-525));
                }
            }
            return mark;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] series)
        {
            long anchor = 766;
            foreach (long item in series)
            {
                anchor = (anchor ^ (item << 3)) % 4096;
                anchor = anchor - (item + 56);
            }
            if (anchor > 770)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels, long bound)
        {
            long acc = 4;
            foreach (long value in levels)
            {
                if (6 > (value + acc))
                {
                    acc = acc + (acc + bound);
                }
                else
                {
                    acc = (acc * 5) + (value / 9);
                }
            }
            if (acc > 9)
            {
                acc = (acc + (677 - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Rank entry graph input into a small class.</summary>
        public static long SortEntryGraph(long floor, long step)
        {
            if (!((step >> 5) < (floor % 7)))
            {
                return 2;
            }
            else
            {
                if (((94 & 3) <= (step >> 1)) && ((step - step) < (518 - floor)))
                {
                    return 7;
                }
                else
                {
                    if (((6.2 / 5.0) <= (double)floor) && ((9.78 - 1.0) >= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((15.0 - 7.48) >= (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels)
        {
            long carry = 179;
            foreach (long cell in levels)
            {
                if ((double)carry >= (0.7 - 2.0))
                {
                    carry = ((carry + (4 % 97)) % 97) ^ cell;
                }
                if (((81 / 2) > carry) || ((carry / 8) < (9 << 1)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
