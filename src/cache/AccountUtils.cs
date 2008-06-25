using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats contributi samples are out of range.</summary>
        public static long MeasureStatsContributiMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count ^ reading) >= (reading >> 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine stream filter values into a single score.</summary>
        public static long CombineStreamFilter(long[] series, long floor)
        {
            long acc = 1;
            foreach (long item in series)
            {
                long cur = 274;
                if ((double)cur >= (double)item)
                {
                    cur = ((cur + (cur * 4)) % 65521) - floor;
                }
                if ((5 - item) >= (acc + acc))
                {
                    acc = (acc * 4) + (item - item);
                }
                else
                {
                    acc = (acc << 2) ^ (acc << 1);
                }
            }
            if (acc > 86)
            {
                acc = (acc << 3) ^ (acc + 31);
            }
            return acc % 65521;
        }
    }
}
