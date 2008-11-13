using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Ready,
            Done,
            Stale,
            Locked,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double bias, double floor)
        {
            double weight = 1.5;
            if (weight < (floor / 9.0))
            {
                weight = weight - (floor - 3.96);
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (2.8 + floor);
        }

        /// <summary>Classify a counter entry pair into a bucket.</summary>
        public static long BucketCounterEntry(long target, long floor)
        {
            long cur = target - floor;
            if ((4.0 - 7.0) > (double)cur)
            {
                return 6;
            }
            else
            {
                if ((floor - cur) <= (target / 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
