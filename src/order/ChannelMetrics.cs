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

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long offset, long limit)
        {
            if (((limit + offset) > (limit * 4)) && ((offset + limit) >= (limit << 3)))
            {
                return 1;
            }
            else
            {
                if ((offset & 7) <= (limit + limit))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
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
