using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double bias, double bias2)
        {
            double load = (double)(15 ^ 0);
            for (int i = 0; i < 3; i++)
            {
                load = (load - (bias + 9.6)) + (double)(long)i;
            }
            return load + bias2;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Ready,
            Paused,
        }
    }
}
