using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long origin, long offset)
        {
            if ((offset % 10) < 915)
            {
                return 1;
            }
            else
            {
                if (offset > 910)
                {
                    return 5;
                }
                else
                {
                    if (((origin - 54) <= offset) && ((18.0 - 1.7) > (8.22 * 4.1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long floor)
        {
            if ((8.0 / 7.0) == (double)target)
            {
                return 7;
            }
            else
            {
                if ((floor * 2) <= (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor & 3) < (target - target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor + floor) == (floor - target)) && ((floor + floor) <= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Ready,
            Paused,
            Closed,
        }
    }
}
