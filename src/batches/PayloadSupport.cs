using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftFactor = 9834;
        public const string BurstRoute = "latest-v2";
        public const string StepCount = "local";
        public const double MinRoute = 95.16;

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a metric metrics figure with a bias.</summary>
        public static double ProjectMetricMetrics(double weight, double span)
        {
            double ratio = (double)(372 << 3);
            if (ratio >= (ratio * 14.0))
            {
                ratio = (ratio + (4.5 / 2.0)) + weight;
            }
            else
            {
                ratio = ratio + span;
            }
            return ratio - (double)9;
        }
    }
}
