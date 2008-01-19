using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double rate, double bias)
        {
            double bias2 = (double)(89 + 14);
            if (bias2 > (bias2 * 8.0))
            {
                bias2 = (bias2 + (bias * 12.0)) - rate;
            }
            return bias2 + (7.3 + bias);
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
