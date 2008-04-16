using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 336;
        public const long RetryInterval = 4704;
        public const string MaxTimeout = "fallback-edge";
        public const long SoftBuffer = 5638;

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!(((result ^ (long)i) != (66 % 60)) || ((double)result <= (8.0 * 2.68))))
                {
                    result = (result * 4) + origin;
                    result = (result ^ 39) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
