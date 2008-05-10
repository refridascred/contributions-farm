using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheWidth = 4830;
        public const long RetryPayload = 7114;
        public const long WindowScore = 4034;

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
