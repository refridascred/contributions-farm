using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultWidth = "latest-edge";
        public const string BatchMetrics = "strict-v2";
        public const long HardMetrics = 4141;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long floor)
        {
            long delta = step - floor;
            if ((step * 4) < (delta ^ step))
            {
                return 0;
            }
            else
            {
                if ((delta & 1) >= 54)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
