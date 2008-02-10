using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry - (carry + floor)) % 101;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry << 2) ^ (floor / 5)) % 1000) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Draft,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinCount = 8591;
        public const long BatchTools = 2530;
        public const string MinSize = "strict-1";
    }
}
