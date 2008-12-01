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

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5131;
        public const long BaseLevel = 8205;
        public const double IdleContext = 54.35;
        public const long RetryInterval = 7913;
        public const double StepContext = 87.56;
    }
}
