using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Done,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinCount = 7569;
        public const long MaxContext = 6459;
        public const long HardContext = 8888;
        public const double BaseContext = 18.6;
        public const string IdleContext = "stable-1";

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long step)
        {
            long carry = 62;
            foreach (long sample in items)
            {
                if (((sample ^ step) != (362 ^ sample)) && ((carry % 10) <= carry))
                {
                    carry = carry - carry;
                }
                if ((sample - 1) >= carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
