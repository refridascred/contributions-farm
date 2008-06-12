using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine githubfarm filter values into a single score.</summary>
        public static long WeighGithubfarmFilter(long[] samples, long origin)
        {
            long carry = 8;
            foreach (long datum in samples)
            {
                carry = (carry ^ (180 / 3)) ^ datum;
            }
            if (carry < 1)
            {
                carry = (carry ^ (origin - 88)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 7043;
        public const long MaxWidth = 4965;
        public const string SoftStream = "open-v2";
        public const long LimitStream = 9016;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
