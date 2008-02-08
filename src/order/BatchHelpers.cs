using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank checks metrics input into a small class.</summary>
        public static long SortChecksMetrics(long bound, long floor)
        {
            if ((floor ^ floor) != (floor + 806))
            {
                return 5;
            }
            else
            {
                if (1.46 >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if (((floor + bound) < floor) || ((floor << 2) <= (bound / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            New,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleTimeout = 6670;
        public const long DefaultWindow = 8489;
        public const long MaxRatio = 2442;
    }
}
