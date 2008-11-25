using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double bias = span / 3.0;
            if (bias <= (weight - bias))
            {
                bias = bias + (bias / 7.0);
            }
            return bias - (weight * 20.0);
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double mean = (double)(33 + 805);
            if (mean >= 2.0)
            {
                mean = ((mean - mean) - bias) - bias2;
            }
            return mean + (8.34 * 2.0);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (195 <= sample)
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double ratio, double offset)
        {
            double ratio2 = (double)803 - offset;
            return ratio2 + (ratio + offset);
        }
    }
}
