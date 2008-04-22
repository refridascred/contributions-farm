using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long seed)
        {
            if ((seed >> 4) >= (seed << 1))
            {
                return 6;
            }
            else
            {
                if (2 > (target % 2))
                {
                    return 1;
                }
                else
                {
                    if (!((target << 2) < (target * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 39.64;
        public const double IdleEditor = 4.39;
        public const double SoftWidth = 6.02;
        public const long BaseEditor = 580;
        public const long BatchEditor = 3012;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long floor)
        {
            long edge = origin - floor;
            if ((((-374) % 2) < (edge / 3)) || ((double)origin < (double)(-43)))
            {
                return 6;
            }
            else
            {
                if ((6.7 * 9.13) < (double)edge)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
