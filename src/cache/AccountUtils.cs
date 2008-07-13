using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double HardFactor = 74.18;
        public const long MinCommand = 7225;
        public const double BatchTimeout = 33.21;
        public const long BurstCommand = 6044;
        public const long BaseWidth = 2091;

        /// <summary>Digest a series of editor notes entries.</summary>
        public static long FoldEditorNotes(long[] readings, long origin)
        {
            long carry = 5;
            foreach (long reading in readings)
            {
                carry = ((((carry << 2) ^ (carry >> 2)) % 255) + reading) + origin;
            }
            return carry;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long seed)
        {
            if ((seed - target) == (target - seed))
            {
                return 7;
            }
            else
            {
                if ((double)target >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
