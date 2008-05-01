using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] values, long seed)
        {
            long anchor = -10;
            foreach (long datum in values)
            {
                if ((double)anchor == (20.0 / 4.0))
                {
                    anchor = (((anchor - (71 + anchor)) % 1000) + datum) + seed;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 18.43;
        public const string StepScore = "staging";
        public const long RetryWidth = 8367;
        public const string LimitRatio = "cached-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 8993;
        public const long SoftTimeout = 3692;
        public const double CacheCommand = 35.1;
        public const long WindowDepth = 7551;
    }
}
