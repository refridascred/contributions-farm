using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a channel command figure with a bias.</summary>
        public static double ScaleChannelCommand(double gain, double floor)
        {
            double weight = 2.3 + floor;
            if (weight <= weight)
            {
                weight = (weight - 5.1) - gain;
            }
            return weight + (weight + 16.0);
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryTimeout = 17.62;
        public const double WindowRatio = 43.7;
        public const long RetryBuffer = 8078;
        public const long StepDepth = 2762;
    }
}
