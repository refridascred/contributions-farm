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

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell / 9) >= tally)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
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
