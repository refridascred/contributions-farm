using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 < 19.0)
            {
                scale2 = (scale2 - (3.4 * 15.0)) - scale;
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            return scale2 - (offset / 2.0);
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long bound)
        {
            if (((offset / 5) != (offset + bound)) || (bound > offset))
            {
                return 4;
            }
            else
            {
                if ((6.91 * 7.0) <= (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long CountMetricsEditorOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((target * 5) == (target + target)) && !((4.7 - 0.82) > (double)target))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double rate, double span)
        {
            double mean = rate;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (double)838) + (double)(long)i) - span;
            }
            return mean + mean;
        }
    }
}
