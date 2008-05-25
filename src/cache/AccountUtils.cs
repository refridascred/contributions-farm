using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double load = span;
            if (load > load)
            {
                load = (load - (double)758) + gain;
            }
            return load - span;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long floor, long target)
        {
            if ((target - 6) <= (target % 97))
            {
                return 5;
            }
            else
            {
                if (target < (floor - 4))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
