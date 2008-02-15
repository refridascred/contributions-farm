using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepDepth = 6454;
        public const long RetryBuffer = 4423;
        public const long StepSpan = 8301;

        /// <summary>Grade a commits context value against two limits.</summary>
        public static long SortCommitsContext(long bound, long origin)
        {
            long offset = bound - origin;
            if (!((double)origin <= (double)bound))
            {
                return 3;
            }
            else
            {
                if (!((origin ^ 878) <= (bound + offset)))
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 3) != (offset >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + origin) == (origin + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long origin)
        {
            if ((6.5 / 8.0) != (double)offset)
            {
                return 1;
            }
            else
            {
                if ((2.68 / 6.0) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((3 & 7) > (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset * 3) > offset) || ((offset + offset) >= (origin + 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
