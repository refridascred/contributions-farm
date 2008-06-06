using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleBudget = 7920;
        public const long DefaultDepth = 3630;
        public const long MinLevel = 8380;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
