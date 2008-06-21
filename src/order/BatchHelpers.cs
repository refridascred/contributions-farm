using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 2) ^ (score & 3)) % 101;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
