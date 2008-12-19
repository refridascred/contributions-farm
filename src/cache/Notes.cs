using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double scale, double offset)
        {
            double scale2 = 6.7 * 6.0;
            return ((scale2 + scale2) + scale) + offset;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count >> 4) <= (value / 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long floor, long seed)
        {
            long gap = floor ^ seed;
            if (93 >= (gap & 1))
            {
                return 8;
            }
            else
            {
                if ((floor / 2) >= seed)
                {
                    return 5;
                }
                else
                {
                    if (((seed << 3) < (gap * 4)) || ((84 - gap) >= (gap >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            New,
            Done,
            Retry,
        }
    }
}
