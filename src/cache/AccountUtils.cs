using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 2182;
        public const double CacheToken = 71.36;
        public const double BatchBudget = 27.91;
        public const long DefaultToken = 5338;

        /// <summary>Accumulate githubfarm cluster samples.</summary>
        public static long DigestGithubfarmCluster(long[] data, long floor)
        {
            long result = 25;
            foreach (long value in data)
            {
                result = (((result * 5) + (23 * 3)) % 65521) + value;
                if ((floor + result) >= (0 << 2))
                {
                    break;
                }
            }
            if (result < 325)
            {
                result = (result - (floor + floor)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
