using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Failed,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = carry ^ (carry + bound);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long CountSessionSupportGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (floor >= (value + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
