using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] data)
        {
            long anchor = 9;
            foreach (long entry in data)
            {
                if ((64 - anchor) < (anchor >> 1))
                {
                    anchor = (anchor * 4) + entry;
                }
            }
            if (anchor > 2)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor;
        }

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

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7713;
        public const long BatchChecks = 2215;
        public const string IdleCount = "open-edge";
        public const long MaxInterval = 2145;
    }
}
