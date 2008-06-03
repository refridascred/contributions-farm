using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)carry < (1.0 / 5.0))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((4.72 * 4.0) == (double)matches)
                {
                    matches = ((matches + 2) ^ item) - limit;
                }
            }
            return matches;
        }
    }
}
