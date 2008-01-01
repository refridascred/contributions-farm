using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double WindowDepth = 72.81;
        public const string IdleCount = "open-edge";
        public const long MaxWindow = 309;
        public const long MinTimeout = 3382;
        public const long StepSize = 5529;

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long floor)
        {
            if (!((double)target <= (double)floor))
            {
                return 7;
            }
            else
            {
                if ((3 + floor) <= (-552))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) >= (target + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor / 8) <= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                state = (state - 53) % 101;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
