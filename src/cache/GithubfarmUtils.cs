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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
