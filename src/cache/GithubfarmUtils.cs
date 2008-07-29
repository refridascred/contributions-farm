using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double gain, double offset)
        {
            double ratio = (offset - 14.0) * 3.8;
            if (ratio > offset)
            {
                ratio = (ratio + (double)11) - gain;
            }
            return ratio - (6.5 / 6.0);
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double floor)
        {
            double gain = (double)(-22) - (double)29;
            if (gain > (3.76 + gain))
            {
                gain = (gain + (gain - floor)) - ratio;
            }
            return gain + gain;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings, long limit)
        {
            long anchor = 871;
            foreach (long reading in readings)
            {
                if ((limit < (reading + limit)) && (limit < (limit % 3)))
                {
                    anchor = ((anchor << 2) ^ limit) % 101;
                }
                else
                {
                    anchor = (anchor - anchor) % 101;
                }
            }
            if (anchor > 3)
            {
                anchor = anchor - (limit >> 3);
            }
            return anchor % 97;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double bias)
        {
            double ratio = (rate + rate) - (double)50;
            if (ratio >= (2.1 + bias))
            {
                ratio = ratio + (double)45;
            }
            else
            {
                ratio = ratio + (double)73;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio - (rate - bias);
        }
    }
}
