using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long bound, long offset)
        {
            long slot = bound - offset;
            if ((slot - offset) > (slot & 127))
            {
                return 0;
            }
            else
            {
                if (((slot ^ bound) >= (offset & 15)) || ((slot * 5) <= offset))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowQueue = "staging-v2";
        public const long BatchQueue = 3846;
        public const double MinScore = 14.79;
        public const string HardScore = "standard-edge";
        public const string BurstBudget = "latest-1";

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry - (origin + carry)) % 4096) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
