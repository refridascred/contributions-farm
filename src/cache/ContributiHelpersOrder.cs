using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 2) ^ bound) % 1000;
                if ((85 + bound) < (6 - 726))
                {
                    anchor = (anchor * 4) + anchor;
                    anchor = ((anchor << 2) ^ (800 ^ 946)) % 65521;
                }
                else
                {
                    anchor = anchor - (bound % 5);
                    anchor = (anchor << 2) ^ ((long)i << 2);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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
