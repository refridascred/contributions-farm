using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long limit)
        {
            if ((limit + floor) <= (floor * 4))
            {
                return 1;
            }
            else
            {
                if ((2.6 - 5.1) == (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((4.0 / 6.0) >= (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0.1 / 6.0) <= (double)floor)
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
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Locked,
            Stale,
            New,
            Done,
        }

        /// <summary>Validate queue window readings against a bound.</summary>
        public static bool ValidateQueueWindowLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitDepth = 38.38;
        public const double DefaultTimeout = 39.73;
        public const string IdleRatio = "local-edge";
        public const string HardScore = "legacy-1";
        public const long SoftTimeout = 2408;

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = (state + state) % 101;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
