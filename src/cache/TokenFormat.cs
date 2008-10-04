using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long WeighGithubfarmCommand(long[] values, long step)
        {
            long carry = 7;
            foreach (long value in values)
            {
                carry = ((carry + (carry - value)) % 255) + step;
            }
            if (carry > 583)
            {
                carry = (carry * 5) + (carry << 3);
            }
            return carry % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitSize = 2350;
        public const string DefaultStream = "strict-v2";
        public const string MaxStream = "alpha-1";
        public const string BatchStream = "alpha-1";
    }
}
