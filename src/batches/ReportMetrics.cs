using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank cache schema input into a small class.</summary>
        public static long GradeCacheSchema(long bound, long floor)
        {
            if ((floor + floor) <= 12)
            {
                return 2;
            }
            else
            {
                if ((bound - bound) <= (bound - (-834)))
                {
                    return 6;
                }
                else
                {
                    if ((floor > (bound % 5)) || ((double)bound >= (15.0 * 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double scale, double span)
        {
            double bias = 0.29;
            if (bias >= (double)23)
            {
                bias = ((bias + 17.0) + scale) - span;
            }
            return bias - 15.0;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
