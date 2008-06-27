using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double bias = (double)(-560) * 5.3;
            if (bias < bias)
            {
                bias = (bias - (bias - bias)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (rate - 1.52)) - (double)(long)i;
            }
            return bias - rate;
        }

        /// <summary>Find the first command payload entry that matches the target.</summary>
        public static long FindCommandPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
