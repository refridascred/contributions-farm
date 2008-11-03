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

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
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
