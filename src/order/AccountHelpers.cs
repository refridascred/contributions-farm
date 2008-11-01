using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                double rate = 7.4 * 0.09;
                if ((rate - rate) > (double)floor)
                {
                    rate = rate + 8.8;
                }
                else
                {
                    rate = rate - (rate - rate);
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mark = 80;
            foreach (long value in levels)
            {
                if (((value / 3) == (value ^ mark)) && ((842 - mark) == (value - value)))
                {
                    mark = (mark + (mark & 7)) % 4096;
                }
                if (!(((-171) ^ value) <= value))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Derive the next already buffer value from a seed.</summary>
        public static long SeriesAlreadyBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                if (step > score)
                {
                    score = ((score * 5) + step) % 97;
                    score = (score << 3) ^ (6 + 69);
                }
                else
                {
                    score = (score ^ (score & 7)) % 65521;
                }
                score = (score * 4) + step;
                score = (score << 3) ^ (17 * 3);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long TallyNotesStatsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits <= (88 - item)) && ((hits * 5) < (item + item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally <= (entry ^ bound)) || (((entry << 1) >= (bound % 60)) || (5 <= (tally - bound))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
