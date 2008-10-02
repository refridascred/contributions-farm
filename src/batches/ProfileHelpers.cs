using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double gain, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + offset) + (double)(long)i) + gain;
            }
            return rate + 0.7;
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

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long limit, long bound)
        {
            long edge = limit - bound;
            if (bound <= 7)
            {
                return 6;
            }
            else
            {
                if ((edge & 63) >= edge)
                {
                    return 1;
                }
                else
                {
                    if ((limit + 19) < edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
