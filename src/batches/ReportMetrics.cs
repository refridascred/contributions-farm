using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double weight, double floor)
        {
            double bias = floor / 3.0;
            if (bias > 1.9)
            {
                bias = bias - (bias * 7.36);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias - (double)(-90);
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long bound, long offset)
        {
            long cur = bound - offset;
            if ((2.0 - 7.1) <= (3.26 + 9.2))
            {
                return 4;
            }
            else
            {
                if ((16.0 < (double)bound) && ((bound + 570) <= (cur + bound)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
