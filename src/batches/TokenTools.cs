using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry + ((long)i ^ (long)i)) % 101;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 4519;
        public const long BatchBudget = 2083;
        public const long StepWidth = 4427;
    }
}
