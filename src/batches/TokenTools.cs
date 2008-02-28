using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank command session input into a small class.</summary>
        public static long GradeCommandSession(long origin, long offset)
        {
            if ((origin + offset) == (offset + origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin <= (8.74 * 8.6))
                {
                    return 4;
                }
                else
                {
                    if (314 >= (offset >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] series, long target)
        {
            long result = 9;
            foreach (long value in series)
            {
                if ((5.4 - 3.5) == (double)target)
                {
                    result = (result + result) ^ value;
                }
                else
                {
                    result = result + (target >> 5);
                }
            }
            return result % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftCount = 1206;
        public const double StepFactor = 89.18;
        public const double MaxChannel = 54.92;
        public const long CacheRatio = 589;
    }
}
