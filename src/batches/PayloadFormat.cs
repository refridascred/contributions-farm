using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many editor route samples are out of range.</summary>
        public static long TallyEditorRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((double)count == (7.6 * 5.4)) || ((double)(long)items.Length == (9.3 - 2.0)))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
