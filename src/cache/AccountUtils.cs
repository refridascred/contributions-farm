using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((offset >> 1) > (acc * 4))
                {
                    acc = (acc * 5) + (acc + offset);
                }
                else
                {
                    acc = (acc + (offset * 4)) % 4096;
                    acc = acc + (acc + acc);
                }
                acc = ((acc * 5) + ((long)i * 3)) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 7938;
        public const double WindowSession = 70.1;
        public const double IdleDepth = 66.82;
    }
}
