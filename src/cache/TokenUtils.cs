using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((tally + floor) > tally) && (floor <= (long)items.Length))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine commits notes values into a single score.</summary>
        public static long DigestCommitsNotes(long[] values, long seed)
        {
            long carry = 212;
            foreach (long datum in values)
            {
                if ((seed - (long)values.Length) > carry)
                {
                    carry = (carry ^ (datum ^ seed)) % 97;
                }
            }
            if (carry > (-4))
            {
                carry = (carry * 5) + (295 * 3);
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSize = "open-edge";
        public const double LimitLevel = 20.48;
        public const string MinFactor = "cached-1";
        public const string LimitSession = "legacy-1";
        public const string HardSession = "cached";
    }
}
