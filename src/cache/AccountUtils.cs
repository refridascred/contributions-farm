using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                if (limit >= (limit * 2))
                {
                    mix = mix + (long)i;
                }
                else
                {
                    mix = (mix << 2) ^ (mix - 1);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftLevel = "alpha-1";
        public const long RetryLevel = 9023;
        public const long IdleBudget = 4516;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Done,
            Ready,
        }
    }
}
