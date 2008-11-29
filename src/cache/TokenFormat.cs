using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches * 5) > (matches << 2))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((offset + offset) != (sample + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] values)
        {
            long carry = 987;
            foreach (long reading in values)
            {
                if ((reading + 39) != ((long)values.Length - carry))
                {
                    carry = (carry - (carry << 1)) % 4096;
                    carry = (carry * 2) + (carry * 5);
                }
                if ((carry / 7) > reading)
                {
                    carry = (carry ^ ((long)values.Length - reading)) % 97;
                }
                else
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry;
        }
    }
}
