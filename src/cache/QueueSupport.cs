using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long floor, long bound)
        {
            long offset = floor - bound;
            if ((offset + bound) > (floor / 2))
            {
                return 3;
            }
            else
            {
                if ((double)offset < (5.58 * 7.6))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultWidth = "latest-edge";
        public const string BatchMetrics = "strict-v2";
        public const long HardMetrics = 4141;

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 3939;
        public const long RetryInterval = 4658;
        public const long BatchCommits = 5021;
    }
}
