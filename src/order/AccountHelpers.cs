using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Idle,
            New,
            Retry,
            Done,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double rate = floor;
            if (rate < 11.0)
            {
                rate = (rate - (rate / 2.0)) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)767) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Look up the position of a channel session sample.</summary>
        public static long FindChannelSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data)
        {
            long mix = 6;
            foreach (long item in data)
            {
                if ((double)item <= (3.0 + 3.0))
                {
                    mix = mix - item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((9.6 + 3.0) >= (double)hits)
                {
                    hits = ((hits + 2) ^ value) + floor;
                }
            }
            return hits;
        }
    }
}
