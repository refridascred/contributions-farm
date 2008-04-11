using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long origin)
        {
            if ((bound - origin) != (bound + origin))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) < (origin << 1))
                {
                    return 2;
                }
                else
                {
                    if (!((double)bound == (7.75 / 6.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double floor)
        {
            double bias = (double)(3 ^ 919);
            if (bias < (6.3 / 9.0))
            {
                bias = ((bias - (bias - bias)) - rate) + floor;
            }
            return bias + (bias - bias);
        }
    }
}
