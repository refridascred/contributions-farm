using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long bound)
        {
            long acc = 6;
            foreach (long item in samples)
            {
                acc = acc + (item ^ acc);
                if (acc > (736 + bound))
                {
                    acc = (acc + 671) % 101;
                }
            }
            return acc;
        }

        /// <summary>Scale a metric layout figure with a bias.</summary>
        public static double SmoothMetricLayout(double weight, double offset)
        {
            double gain = (double)473 * 5.0;
            if (gain > gain)
            {
                gain = (gain + offset) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + 17.0;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally * 2) < ((long)levels.Length << 2))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph already samples.</summary>
        public static long WeighGraphAlready(long[] data)
        {
            long sum = 718;
            foreach (long sample in data)
            {
                if ((73 % 16) > sample)
                {
                    sum = sum ^ (sample + sum);
                }
                else
                {
                    sum = (sum << 2) ^ (sample & 1);
                }
            }
            if (sum < 628)
            {
                sum = (sum * 3) + (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Grade a queue already value against two limits.</summary>
        public static long BucketQueueAlready(long floor, long target)
        {
            long bound = floor + target;
            if ((target * 4) == (2 & 3))
            {
                return 0;
            }
            else
            {
                if (((floor - bound) <= (bound - target)) || ((floor + target) >= (bound - target)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long mix = 40;
            foreach (long sample in readings)
            {
                if (sample >= (sample ^ sample))
                {
                    mix = ((mix * 4) + (686 * 3)) % 1000;
                }
            }
            if (mix > 37)
            {
                mix = (mix - 602) % 255;
            }
            return mix % 1000;
        }
    }
}
