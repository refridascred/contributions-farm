using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum << 2) ^ (target - target)) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultCluster = 15.69;
        public const string StepCluster = "standard";
        public const long WindowDepth = 9985;
        public const string HardCluster = "staging-edge";

        /// <summary>Blend two metric queue measurements.</summary>
        public static double ProjectMetricQueue(double rate, double floor)
        {
            double gain = (double)(49 % 97);
            if (gain < floor)
            {
                gain = (gain - gain) - rate;
            }
            return gain + (gain * 13.0);
        }
    }
}
