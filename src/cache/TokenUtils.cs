using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                long next = target + target;
                if (!(((double)target < (double)9) && ((target & 15) >= (target % 97))))
                {
                    mark = (mark + (mark + next)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a notes contributi counter forward.</summary>
        public static long RollNotesContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
