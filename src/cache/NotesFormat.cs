using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the graph schema series from a seed.</summary>
        public static long DeriveGraphSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry << 2) ^ (offset + carry)) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "primary-1";
        public const long BurstRatio = 4938;
        public const string MaxScore = "cached-v2";
        public const long BurstScore = 1529;
        public const long LimitInterval = 110;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Idle,
            Ready,
            Retry,
        }
    }
}
