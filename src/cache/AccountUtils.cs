using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (step + (long)i)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a farm batch value against two limits.</summary>
        public static long ClassifyFarmBatch(long floor, long floor2)
        {
            if ((floor - floor) == (floor / 3))
            {
                return 6;
            }
            else
            {
                if ((double)floor2 != (4.1 - 9.9))
                {
                    return 5;
                }
                else
                {
                    if (((double)floor >= (13.0 * 17.0)) && ((floor + 116) > floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
