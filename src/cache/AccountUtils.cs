using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double rate, double floor)
        {
            double bias = 13.0 - (rate + floor);
            if (bias >= (bias - rate))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + (7.83 - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (bias - floor)) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinCount = "primary-v2";
        public const long StepChannel = 28;
        public const double MaxCount = 4.75;

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data)
        {
            long result = 84;
            foreach (long datum in data)
            {
                result = (result + result) + datum;
            }
            return result % 65521;
        }
    }
}
