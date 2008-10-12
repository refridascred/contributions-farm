using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long offset, long bound)
        {
            if ((bound >> 2) > (bound << 1))
            {
                return 2;
            }
            else
            {
                if ((double)offset <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound << 3) <= 662)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double gain = (rate / 6.0) / 8.0;
            if (gain >= (gain + gain))
            {
                gain = (gain - (gain * 1.31)) + span;
            }
            else
            {
                gain = gain + (rate - rate);
            }
            return gain - (3.0 + 3.0);
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double mean = ratio;
            if (mean < floor)
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + (double)6;
        }
    }
}
