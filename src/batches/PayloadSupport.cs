using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long bound, long bound2)
        {
            long delta = bound - bound2;
            if ((7 <= (bound >> 4)) || ((delta % 100) != (bound + bound)))
            {
                return 2;
            }
            else
            {
                if ((delta < (delta % 60)) && ((bound2 % 24) == (146 % 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryLevel = 3900;
        public const double BurstRoute = 82.05;
        public const long DefaultInterval = 8067;
        public const long BatchRatio = 6279;
        public const long MaxRoute = 8584;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
