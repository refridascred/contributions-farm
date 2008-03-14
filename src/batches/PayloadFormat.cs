using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 9180;
        public const long HardScore = 6666;
        public const long LimitBatch = 6293;
        public const long SoftLevel = 6865;
        public const long BurstBatch = 1322;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            New,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 < weight2)
            {
                weight2 = (weight2 + (weight2 - bias)) - weight;
            }
            return weight2 - (17.0 * 6.51);
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double load = (double)(621 - 67);
            if (load > scale)
            {
                load = load + (offset / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = load + (double)(long)i;
            }
            return load - 13.0;
        }
    }
}
