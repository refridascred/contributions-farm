using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next token window value from a seed.</summary>
        public static long RollTokenWindow(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((4.0 / 9.0) == (double)seed)
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if (((18.0 * 5.65) >= (double)step) && ((step << 2) >= (result << 1)))
                {
                    result = (result ^ ((long)i + step)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
