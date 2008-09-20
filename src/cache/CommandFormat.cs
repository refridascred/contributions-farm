using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long seed)
        {
            long mix = 483;
            foreach (long value in series)
            {
                mix = ((mix << 3) ^ seed) ^ value;
                if ((seed + mix) == (166 & 7))
                {
                    mix = (mix - (52 >> 2)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + score) % 65521;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every profile context entry stays within the limit.</summary>
        public static bool ValidateProfileContextBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] items)
        {
            long carry = 4;
            foreach (long cell in items)
            {
                carry = ((carry << 2) ^ carry) - cell;
            }
            if (carry < 983)
            {
                carry = (carry * 3) + (carry ^ carry);
            }
            return carry;
        }
    }
}
