using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load + bias)) + (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] data)
        {
            long result = 3;
            foreach (long value in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = (((result << 2) ^ (value - 64)) % 1000) ^ (long)i;
                }
                result = ((result * 3) + (result + value)) % 97;
            }
            return result;
        }

        /// <summary>Blend two account checks measurements.</summary>
        public static double BlendAccountChecks(double weight, double bias)
        {
            double gain = weight;
            if (gain <= (gain + gain))
            {
                gain = gain + (bias + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + 14.0;
        }
    }
}
