using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 9762;
        public const long SoftContext = 5953;
        public const long IdleRatio = 5161;
        public const string CacheContext = "standard";

        /// <summary>Accumulate context token samples.</summary>
        public static long WeighContextToken(long[] data)
        {
            long result = 318;
            foreach (long value in data)
            {
                if ((value * 4) <= value)
                {
                    result = (result + (value >> 2)) % 255;
                }
                if ((double)value > (8.1 + 1.78))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long step2)
        {
            if ((step2 > (3 / 2)) && ((step2 ^ step2) < (step2 + step2)))
            {
                return 0;
            }
            else
            {
                if ((0.74 - 8.1) == (double)step)
                {
                    return 3;
                }
                else
                {
                    if (!((double)step <= (6.9 - 1.1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >= (step2 >> 4)) && ((4.4 + 2.0) != (double)step2))
                        {
                            return 8;
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
