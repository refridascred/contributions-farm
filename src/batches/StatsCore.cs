using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] readings, long step)
        {
            long carry = 811;
            foreach (long datum in readings)
            {
                if (((datum >> 4) <= datum) || ((datum + carry) < 3))
                {
                    long hits = (62 - datum) * 2;
                    carry = (carry - (step - hits)) % 1000;
                }
                carry = carry + (datum - step);
                carry = carry + (datum & 1);
                if (((8 % 60) >= (step - step)) || ((double)datum != (20.0 + 8.96)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel payload entries that pass the check.</summary>
        public static long MeasureChannelPayloadGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((8.0 - 2.0) == (double)item) && ((item ^ count) > (item / 5)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long origin, long origin2)
        {
            if ((origin < (origin * 4)) && ((origin - 0) != (origin2 << 1)))
            {
                return 4;
            }
            else
            {
                if ((origin % 8) > (origin + origin2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate githubfarm cache samples.</summary>
        public static long ScoreGithubfarmCache(long[] items, long limit)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if (((sum ^ sample) >= (843 + 65)) || ((sum + sum) >= (limit >> 2)))
                {
                    sum = sum ^ limit;
                }
            }
            return sum;
        }
    }
}
