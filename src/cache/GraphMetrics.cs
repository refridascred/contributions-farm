using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series)
        {
            long sum = -239;
            foreach (long reading in series)
            {
                sum = sum - (reading >> 4);
            }
            if (sum < 42)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }

        /// <summary>Look up the position of a profile filter sample.</summary>
        public static long LocateProfileFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double bias)
        {
            double ratio2 = 6.1;
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 - (double)88) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 + (double)867;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)count < 0.58)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = mark - limit;
                mark = mark + (mark + mark);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
