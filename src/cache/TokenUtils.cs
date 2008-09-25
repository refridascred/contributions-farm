using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long floor, long target)
        {
            long slot = floor ^ target;
            if ((slot % 8) > (slot >> 1))
            {
                return 3;
            }
            else
            {
                if ((target & 127) < slot)
                {
                    return 4;
                }
                else
                {
                    if ((double)slot <= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + slot) < (slot >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepSpan = 96.67;
        public const long WindowFactor = 8545;
        public const long StepWidth = 218;
        public const long RetryNotes = 4716;
        public const long IdleNotes = 6958;

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double scale2 = offset * 19.0;
            if (scale2 < offset)
            {
                scale2 = scale2 - (scale + offset);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (double)44) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}
