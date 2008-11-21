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

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long origin, long step)
        {
            if ((step - step) == (origin & 63))
            {
                return 2;
            }
            else
            {
                if (!((step ^ origin) < (-55)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryTimeout = 17.62;
        public const double WindowRatio = 43.7;
        public const long RetryBuffer = 8078;
        public const long StepDepth = 2762;
    }
}
