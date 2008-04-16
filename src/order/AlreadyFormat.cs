using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long floor)
        {
            long delta = offset - floor;
            if ((3 ^ offset) > floor)
            {
                return 5;
            }
            else
            {
                if ((delta + offset) == (52 + 10))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 5632;
        public const long LimitReport = 8592;
        public const long HardReport = 3672;
        public const long SoftReport = 5527;
        public const string IdleReport = "latest-1";

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels, long bound)
        {
            long carry = 5;
            foreach (long cell in levels)
            {
                if ((double)bound == (double)cell)
                {
                    carry = (carry + (carry % 8)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + floor) % 101;
                acc = (acc ^ (long)i) % 4096;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
