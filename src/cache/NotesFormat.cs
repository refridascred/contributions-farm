using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = (state + offset) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next already githubfarm value from a seed.</summary>
        public static long IterateAlreadyGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry << 2) ^ (carry / 3)) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
