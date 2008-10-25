using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Stale,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowSpan = 440;
        public const string WindowDepth = "alpha-edge";
        public const string IdleCount = "local";
        public const long RetryMetric = 3313;
        public const long HardMetric = 6862;

        /// <summary>Grade a layout farm value against two limits.</summary>
        public static long ClassifyLayoutFarm(long bound, long floor)
        {
            if ((double)floor != (7.87 - 4.5))
            {
                return 2;
            }
            else
            {
                if (floor <= (805 << 1))
                {
                    return 5;
                }
                else
                {
                    if ((91 / 9) >= (bound >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
