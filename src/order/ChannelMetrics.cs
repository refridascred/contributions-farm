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

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] levels, long target)
        {
            long sum = -7;
            foreach (long sample in levels)
            {
                if ((double)target > 5.13)
                {
                    sum = sum + (target + sum);
                }
                else
                {
                    sum = sum + sample;
                }
            }
            if (sum < (-1))
            {
                sum = (sum * 2) + (target % 16);
            }
            return sum % 97;
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
