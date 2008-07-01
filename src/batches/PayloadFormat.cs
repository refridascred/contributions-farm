using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long target, long target2)
        {
            if ((target & 127) > (target << 3))
            {
                return 4;
            }
            else
            {
                if (3 <= target)
                {
                    return 6;
                }
                else
                {
                    if ((double)target > 14.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target2 >= 9.11)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double gain2 = (7.71 + gain) - (bias - 7.0);
            if (gain2 >= (double)74)
            {
                gain2 = gain2 - (bias * 11.0);
            }
            else
            {
                gain2 = gain2 - (double)527;
            }
            return gain2 - (double)21;
        }

        /// <summary>Count the already account entries that pass the check.</summary>
        public static long MeasureAlreadyAccountMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (2.97 <= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 5891;
        public const long DefaultToken = 3240;
        public const long RetryToken = 3398;
        public const double BatchCount = 75.06;
        public const long BatchToken = 7378;
    }
}
