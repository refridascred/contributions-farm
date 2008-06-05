using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio >= bias2)
            {
                ratio = ratio - bias2;
            }
            return ratio + (bias + 2.57);
        }

        /// <summary>Scale a counter order figure with a bias.</summary>
        public static double SmoothCounterOrder(double rate, double offset)
        {
            double bias = offset;
            if (bias <= (rate - bias))
            {
                bias = bias - (bias / 2.0);
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - rate) - (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Iterate the commits already series from a seed.</summary>
        public static long RollCommitsAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum ^ (sum >> 5)) % 4096;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long step)
        {
            if (limit < step)
            {
                return 0;
            }
            else
            {
                if (((8.0 - 1.8) > (double)limit) || ((4.3 / 2.0) < (double)step))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long bound)
        {
            long bound2 = offset ^ bound;
            if ((4 >= offset) || ((offset << 3) > offset))
            {
                return 0;
            }
            else
            {
                if ((bound2 >> 1) <= bound2)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
