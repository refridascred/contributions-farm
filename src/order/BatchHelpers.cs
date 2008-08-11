using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long floor, long origin)
        {
            if ((6 - origin) >= (origin + 6))
            {
                return 3;
            }
            else
            {
                if ((6.25 - 1.3) >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (5.3 * 3.1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin - 15) != (origin % 64))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stats profile entry stays within the limit.</summary>
        public static bool ValidateStatsProfileRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 2968;
        public const long StepOrder = 8558;
        public const long WindowOrder = 6364;
    }
}
