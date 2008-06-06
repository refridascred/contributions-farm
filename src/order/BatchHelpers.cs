using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long floor)
        {
            long cur = step - floor;
            if (((step - cur) <= (43 + floor)) && (cur < (step + floor)))
            {
                return 1;
            }
            else
            {
                if (((step + step) != (cur % 16)) && (39 < (cur << 3)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 856;
        public const long RetryTools = 497;
        public const double BaseInterval = 57.38;
        public const long StepSpan = 8121;
        public const double IdleSize = 53.7;

        /// <summary>Classify a session metric pair into a bucket.</summary>
        public static long GradeSessionMetric(long origin, long limit)
        {
            long offset = origin ^ limit;
            if (offset >= (origin + limit))
            {
                return 2;
            }
            else
            {
                if ((2.66 - 8.4) != (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset >= 20.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
