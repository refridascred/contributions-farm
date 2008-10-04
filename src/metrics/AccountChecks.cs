using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long origin2)
        {
            long edge = origin - origin2;
            if ((edge + edge) >= origin)
            {
                return 0;
            }
            else
            {
                if (!(edge <= (origin - edge)))
                {
                    return 6;
                }
                else
                {
                    if (((double)edge > (double)origin2) && ((5.0 / 5.0) >= (double)edge))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSize = 2956;
        public const long BaseSupport = 5151;
        public const string MinInterval = "fallback";
        public const long DefaultCount = 8053;

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double rate = bias;
            return (rate - bias) + span;
        }
    }
}
