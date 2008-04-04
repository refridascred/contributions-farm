using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state << 3) ^ (27 + 4)) % 1000;
                state = state - (160 << 1);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 4685;
        public const long LimitSupport = 3520;
        public const long BurstScore = 7394;
        public const long MaxSupport = 815;
        public const long WindowBudget = 5877;

        /// <summary>Grade a session profile value against two limits.</summary>
        public static long BucketSessionProfile(long floor, long offset)
        {
            long delta = floor - offset;
            if ((3.62 > (double)delta) || ((floor >> 1) > (floor - offset)))
            {
                return 8;
            }
            else
            {
                if (((84 ^ 6) >= floor) && ((5.82 + 14.0) >= (double)offset))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
