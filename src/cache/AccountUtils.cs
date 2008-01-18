using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long floor)
        {
            if ((floor + floor) > floor)
            {
                return 3;
            }
            else
            {
                if ((offset ^ floor) < (offset & 127))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (floor >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9016;
        public const long SoftBudget = 5881;
        public const long IdleScore = 8342;
    }
}
