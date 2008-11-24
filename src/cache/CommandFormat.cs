using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a route support pair into a bucket.</summary>
        public static long SortRouteSupport(long limit, long origin)
        {
            if ((double)limit > (6.7 - 3.8))
            {
                return 8;
            }
            else
            {
                if (3.48 < (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many tools entry samples are out of range.</summary>
        public static long MeasureToolsEntryGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)step > (5.57 * 2.2))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long sum = 6;
            foreach (long entry in items)
            {
                if ((entry - entry) == (225 - 885))
                {
                    sum = ((sum * 2) + (sum / 7)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 101;
                }
            }
            if (sum > 13)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
