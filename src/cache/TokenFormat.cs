using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double load = 8.47 / 5.0;
            return ((load + load) + rate) + floor;
        }

        /// <summary>Iterate the schema order series from a seed.</summary>
        public static long IterateSchemaOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i < (bound - (-36)))
                {
                    result = ((result << 2) ^ (result + bound)) % 255;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double bias, double bias2)
        {
            double gain = 2.5;
            if (gain >= 5.74)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (bias2 + bias)) + (double)(long)i;
            }
            return gain + bias;
        }
    }
}
