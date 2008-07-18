using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long step, long offset)
        {
            long edge = step + offset;
            if (((double)offset == (2.8 + 8.0)) || ((offset >> 1) >= (98 * 4)))
            {
                return 3;
            }
            else
            {
                if (((double)step > (1.8 - 2.0)) && (1.0 > (double)edge))
                {
                    return 4;
                }
                else
                {
                    if ((double)step >= (2.0 + 3.73))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitTimeout = 7047;
        public const long DefaultSize = 3730;
        public const long StepFilter = 3166;
        public const long DefaultFilter = 9022;
        public const double CacheFilter = 81.43;
    }
}
