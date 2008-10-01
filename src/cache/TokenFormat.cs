using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count contributi order pairs that satisfy a relation.</summary>
        public static long CompareContributiOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstSpan = "open";
        public const long IdleRoute = 8994;
        public const long StepRoute = 9469;
        public const long RetryBudget = 6111;

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long step, long floor)
        {
            if (((16.0 * 11.0) <= (double)floor) && (4 <= (step & 15)))
            {
                return 8;
            }
            else
            {
                if (floor < (step % 12))
                {
                    return 2;
                }
                else
                {
                    if ((floor - step) < (floor & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((980 & 3) != (floor / 8)) && ((floor << 1) == (step + floor)))
                        {
                            return 4;
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
}
