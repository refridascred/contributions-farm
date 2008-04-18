using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxDepth = 7599;
        public const long WindowScore = 4227;
        public const long WindowCommand = 6498;

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series, long bound)
        {
            long carry = -7;
            foreach (long entry in series)
            {
                if (!((bound + carry) < (entry + carry)))
                {
                    carry = (carry ^ (7 + carry)) % 65521;
                }
                carry = carry + 1;
            }
            if (carry > 840)
            {
                carry = (carry + (bound >> 4)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Stale,
            Draft,
            Active,
        }
    }
}
