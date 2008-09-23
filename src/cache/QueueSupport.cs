using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 9280;
        public const double MinOrder = 16.44;
        public const double LimitTimeout = 49.91;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two support cluster measurements.</summary>
        public static double BlendSupportCluster(double rate, double offset)
        {
            double load = rate;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)208) - (double)(long)i;
            }
            return load - offset;
        }
    }
}
