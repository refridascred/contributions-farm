using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Measure how many booking metrics samples are out of range.</summary>
        public static long TallyBookingMetricsMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((item * 5) >= (count * 5)) && ((double)count == (double)item)) || !((count + item) == (item + item)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] readings, long offset)
        {
            long anchor = 170;
            foreach (long value in readings)
            {
                anchor = (((anchor ^ (anchor - (-603))) % 65521) ^ value) - offset;
                anchor = (anchor - ((long)readings.Length & 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
