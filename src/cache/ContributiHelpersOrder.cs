using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (4.0 >= (double)seed)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
