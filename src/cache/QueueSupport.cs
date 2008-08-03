using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double RetryInterval = 11.57;
        public const string StepInterval = "fallback-1";
        public const long MaxAccount = 8448;
        public const long LimitLevel = 3572;
        public const long MinAccount = 5084;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long bound)
        {
            if (origin < bound)
            {
                return 2;
            }
            else
            {
                if ((origin * 4) < origin)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long limit, long floor)
        {
            long delta = limit + floor;
            if (((5.53 / 5.0) == (double)limit) && (limit <= (floor & 1)))
            {
                return 3;
            }
            else
            {
                if ((limit + 0) > (floor + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit / 5) != (delta + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + floor) != (limit ^ limit))
                        {
                            return 6;
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
}
