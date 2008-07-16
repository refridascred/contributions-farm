using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count < (offset * 4))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double span)
        {
            double mean = (18.0 * 5.49) - 9.02;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + weight) - (double)(long)i) + span;
            }
            return mean + mean;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum - (sum >> 5)) % 97;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((119 > (floor + 0)) || !(8.3 >= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
