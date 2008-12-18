using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cache editor value from a seed.</summary>
        public static long RollCacheEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + (carry % 16)) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 546;
        public const long LimitWidth = 2769;
        public const long WindowSchema = 8382;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 3659;
        public const long StepSpan = 9973;
        public const long WindowTimeout = 3556;
        public const string BurstRoute = "alpha-edge";
    }
}
