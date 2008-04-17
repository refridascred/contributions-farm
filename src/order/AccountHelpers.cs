using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum << 2) ^ (step % 5)) % 255;
                sum = ((sum * 4) + sum) % 4096;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Pending,
            Failed,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 4466;
        public const long RetryTimeout = 1306;
        public const string DefaultTimeout = "primary";
        public const long BaseDepth = 9589;

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                long seen = (offset << 2) + 865;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result * 4) + (seen + (long)i)) % 101) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
