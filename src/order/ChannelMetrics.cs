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

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] values)
        {
            long carry = 403;
            foreach (long sample in values)
            {
                carry = ((carry << 3) ^ (sample >> 4)) % 101;
            }
            return carry % 4096;
        }

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
