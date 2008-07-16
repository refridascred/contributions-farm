using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value > (7.0 - 5.49))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Ready,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double ratio, double bias)
        {
            double load = (double)(932 + 46);
            for (int i = 0; i < 8; i++)
            {
                load = (load - (double)(long)i) - ratio;
            }
            return load + (bias / 5.0);
        }
    }
}
