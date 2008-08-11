using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - value) > (822 + value))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 494;
        public const long MinMetrics = 5073;
        public const string BurstRatio = "staging-edge";
        public const long MinRatio = 1160;
    }
}
