using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double scale = ratio * 4.9;
            if (scale > (ratio + ratio))
            {
                scale = (scale + 3.9) + bias;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 8.2;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double gain2 = (14.0 / 6.0) + 19.0;
            if (gain2 > (gain + gain))
            {
                gain2 = (gain2 - gain2) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - 9.4) + (double)(long)i;
            }
            return gain2 - 3.62;
        }

        /// <summary>Blend two editor metrics measurements.</summary>
        public static double BlendEditorMetrics(double bias, double bias2)
        {
            double mean = (bias + bias) - 2.1;
            if (mean <= (mean / 2.0))
            {
                mean = (mean + bias) - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Find the first command session entry that matches the target.</summary>
        public static long LookupCommandSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
