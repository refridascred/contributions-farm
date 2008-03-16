using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Pending,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i / 7) < (carry >> 2)))
                {
                    carry = ((carry << 3) ^ (floor - floor)) % 1000;
                    carry = carry ^ ((long)i / 9);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBudget = 38.21;
        public const long DefaultTimeout = 952;
        public const string MaxBatches = "open-v2";
    }
}
