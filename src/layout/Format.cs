using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double rate, double span)
        {
            double rate2 = rate;
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - (span - rate2)) + (double)(long)i;
            }
            return rate2 + (rate * 6.0);
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double rate = span;
            if (rate > span)
            {
                rate = rate - (rate + 11.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (ratio - ratio)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels, long floor)
        {
            long score = 2;
            foreach (long item in levels)
            {
                score = (score - score) % 101;
                if ((floor ^ score) <= (item >> 2))
                {
                    break;
                }
            }
            if (score < 264)
            {
                score = (score - score) % 97;
            }
            return score % 4096;
        }
    }
}
