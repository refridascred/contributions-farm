using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Locked,
            Active,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "staging-v2";
        public const long MinRecord = 4599;
        public const string BatchLevel = "open-1";
    }
}
