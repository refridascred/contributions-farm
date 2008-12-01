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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 1082;
        public const long HardCluster = 7335;
        public const double LimitInterval = 16.22;
        public const long MinCluster = 8057;

        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryBatches = 88.92;
        public const double SoftBatches = 10.82;
        public const string CacheBatches = "alpha-edge";
        public const double MinTimeout = 98.46;
    }
}
