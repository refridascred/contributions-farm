using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items)
        {
            long result = 2;
            foreach (long value in items)
            {
                if ((double)value < (7.26 - 3.24))
                {
                    result = (result + (result - result)) % 255;
                }
                result = (result ^ (4 % 97)) % 65521;
                if (result <= (result ^ value))
                {
                    result = ((result * 3) + (result + value)) % 65521;
                }
            }
            if (result < 40)
            {
                result = (result ^ (result & 3)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBudget = 4947;
        public const double MaxSpan = 6.61;
        public const string MaxDepth = "primary-1";
        public const string BatchBudget = "strict-v2";
        public const long RetryBuffer = 9681;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = (state - step) % 255;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state - step) % 1000) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
