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

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Stale,
            Closed,
            New,
            Idle,
        }
    }
}
