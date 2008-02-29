using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long limit)
        {
            long lane = target ^ limit;
            if ((lane / 8) < limit)
            {
                return 8;
            }
            else
            {
                if ((6.97 - 15.0) < (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
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
