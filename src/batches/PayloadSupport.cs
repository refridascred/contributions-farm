using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitScore = 8864;
        public const long BurstStream = 2255;
        public const long DefaultStream = 2005;
        public const long IdleStream = 1092;
        public const string RetrySpan = "legacy-edge";

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double bias, double span)
        {
            double weight = (span * 3.2) / 2.0;
            if (weight >= (bias + 12.0))
            {
                weight = weight + (double)4;
            }
            return weight - (bias + bias);
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series)
        {
            long mark = 772;
            foreach (long sample in series)
            {
                if (sample > (sample ^ mark))
                {
                    mark = mark - (sample * 3);
                }
            }
            if (mark < 64)
            {
                mark = (mark << 3) ^ (0 + mark);
            }
            return mark % 1000;
        }
    }
}
