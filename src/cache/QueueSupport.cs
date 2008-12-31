using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long origin, long floor)
        {
            if ((6.69 * 6.4) == (double)floor)
            {
                return 6;
            }
            else
            {
                if (15 >= origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchWidth = 5624;
        public const string RetryMetric = "cached-1";
        public const string WindowDepth = "open-edge";
        public const long MaxBudget = 9687;

        /// <summary>Define format limits and defaults.</summary>
        public const double StepCount = 83.69;
        public const double HardTimeout = 64.65;
        public const long StepFormat = 1212;
        public const long LimitFactor = 5742;
        public const long DefaultLevel = 881;
    }
}
