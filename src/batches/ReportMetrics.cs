using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double ratio, double offset)
        {
            double load = 6.4;
            return ((load - (load * 20.0)) + ratio) + offset;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowFactor = 2557;
        public const long BaseBudget = 2146;
        public const long StepCounter = 210;
        public const long DefaultSize = 81;
        public const long DefaultCounter = 6359;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
