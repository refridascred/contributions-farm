using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double bias)
        {
            double ratio2 = bias;
            return ratio2 + (ratio / 4.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitDepth = 97.13;
        public const double StepOrder = 41.6;
        public const long SoftOrder = 5742;
        public const double DefaultOrder = 3.19;
        public const long RetrySpan = 2463;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "fallback-edge";
        public const long RetryInterval = 7631;
        public const long MinChecks = 8697;
        public const string MaxDepth = "local-v2";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
