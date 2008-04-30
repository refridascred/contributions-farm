using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many checks session samples are out of range.</summary>
        public static long TallyChecksSessionGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((target + hits) < 3)
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 5166;
        public const long LimitWidth = 1622;
        public const long BurstRoute = 9830;
        public const long HardRoute = 8328;

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double floor)
        {
            double load = 1.14;
            for (int i = 0; i < 3; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + (ratio - ratio);
        }
    }
}
