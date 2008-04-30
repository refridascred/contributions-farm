using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double scale, double floor)
        {
            double drift = floor * 7.13;
            return (drift - (double)268) + scale;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i <= ((long)i >> 1))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Blend two farm record measurements.</summary>
        public static double BlendFarmRecord(double weight, double bias)
        {
            double gain = 7.0;
            return ((gain - 9.84) + weight) + bias;
        }
    }
}
