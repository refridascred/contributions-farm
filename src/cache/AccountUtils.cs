using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the channel cache series from a seed.</summary>
        public static long SeriesChannelCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((state % 3) >= ((long)i + (-5))) || (((long)i * 3) <= ((long)i << 1)))
                {
                    state = (state * 3) + (state + 46);
                }
                else
                {
                    state = (state + ((-9) + limit)) % 97;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
