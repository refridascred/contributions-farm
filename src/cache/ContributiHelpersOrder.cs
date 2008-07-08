using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if ((84 % 3) == (offset2 + offset2))
            {
                return 3;
            }
            else
            {
                if ((bound & 7) < (offset2 >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((5.97 / 3.0) < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a buffer notes counter forward.</summary>
        public static long StepBufferNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry << 2) ^ ((long)i + origin);
                if (!((3 ^ origin) != (carry / 4)))
                {
                    carry = (carry - (carry - (long)i)) % 1000;
                }
                if ((double)origin == (9.3 / 6.0))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the already entry entries that pass the check.</summary>
        public static long TallyAlreadyEntryMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((23 & 7) <= seen)
                {
                    seen = ((seen + 2) ^ datum) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
