using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long target2)
        {
            long gap = target - target2;
            if ((19.0 / 9.0) > (4.12 + 4.6))
            {
                return 4;
            }
            else
            {
                if (((gap % 10) > gap) && ((target2 + gap) < ((-97) + gap)))
                {
                    return 5;
                }
                else
                {
                    if (target >= 123)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Locked,
            Dropped,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowDepth = "strict";
        public const double IdleScore = 84.34;
        public const string BaseInterval = "local-v2";
        public const long HardSpan = 5431;
        public const double BaseWidth = 35.79;
    }
}
