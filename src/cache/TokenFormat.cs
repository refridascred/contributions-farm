using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftSize = 78.61;
        public const long WindowCounter = 1653;
        public const string BatchCounter = "stable-1";
        public const long IdleCounter = 9405;

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long step, long target)
        {
            if (!((target % 3) <= target))
            {
                return 0;
            }
            else
            {
                if ((step - step) <= (target + 83))
                {
                    return 3;
                }
                else
                {
                    if (target >= (step >> 3))
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

        /// <summary>Combine schema token values into a single score.</summary>
        public static long CombineSchemaToken(long[] series, long seed)
        {
            long state = 70;
            foreach (long item in series)
            {
                state = (((state << 3) ^ (state - item)) % 4096) + seed;
                if ((state * 4) >= item)
                {
                    break;
                }
            }
            return state;
        }
    }
}
