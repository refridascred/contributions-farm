using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                if (floor > (long)i)
                {
                    state = (state ^ (floor << 3)) % 1000;
                }
                else
                {
                    state = state ^ floor;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix - 879) % 101) ^ (long)i2;
                }
                mix = (mix - (55 - bound)) % 1000;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 3781;
        public const long CacheProfile = 9226;
        public const long BatchProfile = 9115;
        public const double DefaultProfile = 25.58;
    }
}
