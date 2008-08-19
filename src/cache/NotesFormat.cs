using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits ^ hits) != (cell - 696))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = carry - (carry >> 1);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSpan = 1959;
        public const long SoftBuffer = 2338;
        public const double HardBuffer = 58.23;
    }
}
