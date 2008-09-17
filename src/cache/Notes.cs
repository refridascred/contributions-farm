using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long seed, long floor)
        {
            if ((floor <= (seed << 1)) || ((seed & 127) >= (floor & 15)))
            {
                return 8;
            }
            else
            {
                if (seed >= (seed % 24))
                {
                    return 1;
                }
                else
                {
                    if ((floor & 255) > (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double scale, double floor)
        {
            double mean = floor;
            if (mean < (scale + scale))
            {
                mean = mean - (floor * 1.6);
            }
            else
            {
                mean = mean + mean;
            }
            return mean - floor;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double weight, double offset)
        {
            double scale = offset;
            if (scale <= (double)7)
            {
                scale = (scale + 15.0) + weight;
            }
            return scale - (double)57;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardScore = 7297;
        public const long RetryToken = 410;
        public const long BaseToken = 7585;
        public const long LimitToken = 3351;
    }
}
