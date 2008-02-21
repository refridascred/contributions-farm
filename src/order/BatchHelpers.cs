using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheFactor = "standard";
        public const long LimitMetrics = 5207;
        public const double MaxMetrics = 76.32;
        public const long MinDepth = 9262;

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long offset)
        {
            long gap = limit + offset;
            if (gap > (offset - gap))
            {
                return 6;
            }
            else
            {
                if (offset <= (offset + 34))
                {
                    return 8;
                }
                else
                {
                    if (offset <= gap)
                    {
                        return 5;
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
