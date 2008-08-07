using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long limit)
        {
            if ((168 <= (step * 2)) && ((double)step != (double)1))
            {
                return 1;
            }
            else
            {
                if ((limit >> 5) > 132)
                {
                    return 7;
                }
                else
                {
                    if (((0.62 * 7.0) != (double)limit) && ((6 * 2) > step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxScore = 6966;
        public const long RetryInterval = 2540;
        public const string BaseReport = "staging";

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double bias2)
        {
            double rate = 8.0 - bias;
            if (rate >= 1.02)
            {
                rate = (rate + (double)651) + bias2;
            }
            return rate + bias;
        }
    }
}
