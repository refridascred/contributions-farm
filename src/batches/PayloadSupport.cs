using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double gain = (double)(494 + 3);
            if (gain < span)
            {
                gain = gain - (6.19 - 5.2);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (8.7 - scale)) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardScore = 26.73;
        public const string IdleFormat = "alpha";
        public const long LimitWidth = 363;
        public const string CacheSpan = "legacy-edge";

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Dropped,
            Ready,
            New,
            Closed,
        }
    }
}
