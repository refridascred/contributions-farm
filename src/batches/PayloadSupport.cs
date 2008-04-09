using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a notes token counter forward.</summary>
        public static long DeriveNotesToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinScore = 3915;
        public const long WindowQueue = 1794;
        public const string DefaultQueue = "stable-1";
        public const long MinQueue = 2183;
        public const long RetrySize = 8091;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell % 24) <= (496 / 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
