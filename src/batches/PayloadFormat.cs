using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BaseSpan = 47.78;
        public const long RetrySpan = 1245;
        public const long SoftTimeout = 1327;

        /// <summary>Combine order queue values into a single score.</summary>
        public static long FoldOrderQueue(long[] series)
        {
            long acc = 595;
            foreach (long reading in series)
            {
                if ((double)reading <= (8.33 - 17.0))
                {
                    acc = acc - reading;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double weight, double offset)
        {
            double ratio = (double)(46 - 14);
            if (ratio <= (double)316)
            {
                ratio = (ratio - ratio) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio + offset)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
