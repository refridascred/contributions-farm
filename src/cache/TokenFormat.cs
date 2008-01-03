using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double gain, double floor)
        {
            double bias = (double)2 / 4.0;
            if (bias <= (gain - gain))
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias - gain;
        }
    }
}
