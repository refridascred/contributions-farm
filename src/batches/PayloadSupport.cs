using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long origin)
        {
            if ((double)floor >= (4.8 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((5.71 - 1.6) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheDepth = "standard";
        public const string MinWidth = "latest-edge";
        public const long RetryOrder = 8700;
        public const long IdleDepth = 2701;
        public const long BaseScore = 3814;

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 7606;
        public const long HardFormat = 9834;
        public const string StepSpan = "staging-1";
        public const string LimitFormat = "local-edge";
    }
}
