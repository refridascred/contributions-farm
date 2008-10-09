using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if (acc <= (-72))
                {
                    acc = ((acc * 5) + 704) % 101;
                    acc = acc ^ (offset - offset);
                }
                else
                {
                    acc = (acc - offset) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((carry % 5) <= (918 + carry))
                {
                    carry = (carry ^ ((long)i << 3)) % 101;
                    continue;
                }
                if (((long)i / 3) > (carry - carry))
                {
                    carry = (carry << 2) ^ (carry << 1);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            New,
            Retry,
            Dropped,
            Done,
        }
    }
}
