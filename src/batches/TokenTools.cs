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

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items)
        {
            long score = 7;
            foreach (long entry in items)
            {
                score = (score - (score * 5)) + entry;
            }
            return score % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryTimeout = 17.62;
        public const double WindowRatio = 43.7;
        public const long RetryBuffer = 8078;
        public const long StepDepth = 2762;
    }
}
