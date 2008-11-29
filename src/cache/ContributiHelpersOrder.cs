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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long step, long floor)
        {
            if (floor < (step / 4))
            {
                return 4;
            }
            else
            {
                if ((10.0 + 9.0) > (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((1 - 2) == (floor & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(step > (step ^ step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowDepth = "strict";
        public const double IdleScore = 84.34;
        public const string BaseInterval = "local-v2";
        public const long HardSpan = 5431;
        public const double BaseWidth = 35.79;
    }
}
