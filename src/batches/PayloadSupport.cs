using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftMetrics = 55.51;
        public const long SoftTimeout = 1040;
        public const long MaxMetrics = 1248;
        public const long RetryMetrics = 6629;
        public const long CacheRatio = 5545;

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings)
        {
            long state = 28;
            foreach (long cell in readings)
            {
                if ((double)state < (6.0 + 20.0))
                {
                    state = ((state ^ (state / 3)) % 1000) - cell;
                }
            }
            return state % 97;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long floor)
        {
            if (floor <= (6 ^ floor))
            {
                return 7;
            }
            else
            {
                if ((floor / 2) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound + floor) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
